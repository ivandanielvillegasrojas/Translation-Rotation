using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using System.IO;

namespace Traslacion_rotacion_OpenGL
{
    public partial class Traslacion_rotacion_OpenGL : Form
    {
        int startCuboDXF = -1, endCuboDXF;
        decimal[] baricentroCuboDXF = new decimal[3];
        int startCuboAlgoritmo = -1, endCuboAlgoritmo;
        decimal[] baricentroCuboAlgoritmo = new decimal[3];
        int startFiguraDXF = -1, endFiguraDXF;
        decimal[] baricentroFiguraDXF = new decimal[3];
        int velocidad = 10;
        int eyeX = 100, eyeY = 100, eyeZ = 100;
        List<Int32> GList;
        List<Dot> dots = new List<Dot>();
        List<Line> lines = new List<Line>();
        List<Rectangle> rectangles = new List<Rectangle>();
        bool loaded = false;

        public Traslacion_rotacion_OpenGL()
        {
            InitializeComponent();
        }

        private void gl_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded) 
                return;

            if (GList == null)
                return;

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            Matrix4 perspective = OpenTK.Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver2, 1F, 0.1F, 20000F);

            GL.LoadMatrix(ref perspective);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            Matrix4 lookat = Matrix4.LookAt(eyeX, eyeY, eyeZ, 0, 0, 0, 0, 1, 0);
            GL.LoadMatrix(ref lookat);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.PushMatrix();
            for (int i = 0; i < GList.Count; i++)
                GL.CallList(GList[i]);

            GL.PopMatrix();
            GL.Finish();
            gl.SwapBuffers();
        }

        private void gl_Load(object sender, EventArgs e)
        {
            loaded = true;
            GL.ClearColor(Color.Black);

            generarFlechas();
            actualizarValor();
        }

        private void tmrRedraw_Tick(object sender, EventArgs e)
        {
            GList = new List<Int32>();
            GList.Add(0);
            foreach (Dot dot in dots)
            {
                GL.NewList(GList.Count, ListMode.Compile);
                GL.PointSize(5);
                GL.Begin(BeginMode.Points);
                GL.Color3(dot.color);

                decimal[] aux_dot = FactoryMatrix.xVxM(dot.matrix, dot.dot);
                GL.Vertex3(Decimal.ToDouble(aux_dot[0]), Decimal.ToDouble(aux_dot[1]), Decimal.ToDouble(aux_dot[2]));

                GL.End();
                GL.EndList();
                GList.Add(GList.Count);
            }

            foreach (Line line in lines)
            {
                decimal[] from = FactoryMatrix.xVxM(line.matrix, line.from);
                decimal[] to = FactoryMatrix.xVxM(line.matrix, line.to);

                GL.NewList(GList.Count, ListMode.Compile);
                GL.Begin(BeginMode.Lines);

                GL.LineWidth(line.width);
                GL.Color3(line.color);
                GL.Vertex3(Decimal.ToDouble(from[0]), Decimal.ToDouble(from[1]), Decimal.ToDouble(from[2]));
                GL.Vertex3(Decimal.ToDouble(to[0]), Decimal.ToDouble(to[1]), Decimal.ToDouble(to[2]));

                GL.End();
                GL.EndList();
                GList.Add(GList.Count);
            }

            foreach (Rectangle rectangle in rectangles)
            {
                GL.NewList(GList.Count, ListMode.Compile);
                GL.PointSize(5);
                GL.Begin(BeginMode.Quads);
                GL.Color3(rectangle.color);
                for (int i = 0; i < rectangle.points.Count; i++)
                {
                    decimal[] aux_dot = FactoryMatrix.xVxM(rectangle.matrix, rectangle.points[i]);
                    GL.Vertex3(Decimal.ToDouble(aux_dot[0]), Decimal.ToDouble(aux_dot[1]), Decimal.ToDouble(aux_dot[2]));
                }
                GL.End();
                GL.EndList();
                GList.Add(GList.Count);
            }

            gl_Paint(gl, null);
        }

        private void nmrUpDown_velocidad_ValueChanged(object sender, EventArgs e)
        {
            velocidad = 20 - (int) nmrUpDown_velocidad.Value;
        }

        private bool cargarDXF(String file, Color color)
        {
            StreamReader SR;

            string s;
            try
            {
                SR = File.OpenText(file);
                s = SR.ReadToEnd();
                SR.Close();
                String[] arr = System.Text.RegularExpressions.Regex.Split(s, "3DFACE");
                for (int i = 1; i < arr.Length; i++)
                {
                    s = arr[i];
                    s = s.Replace('.', ',');
                    String[] arr2 = s.Split('\n');
                    Rectangle r = new Rectangle();
                    r.points[0][0] = decimal.Parse(arr2[6]);
                    r.points[0][1] = decimal.Parse(arr2[8]);
                    r.points[0][2] = decimal.Parse(arr2[10]);
                    r.points[1][0] = decimal.Parse(arr2[12]);
                    r.points[1][1] = decimal.Parse(arr2[14]);
                    r.points[1][2] = decimal.Parse(arr2[16]);
                    r.points[2][0] = decimal.Parse(arr2[18]);
                    r.points[2][1] = decimal.Parse(arr2[20]);
                    r.points[2][2] = decimal.Parse(arr2[22]);
                    r.points[3][0] = decimal.Parse(arr2[24]);
                    r.points[3][1] = decimal.Parse(arr2[26]);
                    r.points[3][2] = decimal.Parse(arr2[28]);
                    r.color = color;
                    rectangles.Add(r);
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Por Favor copie los archivos DXF 'a3dchair' y 'cubo' en el directorio donde esta corriendo la aplicación", "ERROR en archivo DXF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #region Punto 1 (DXF cubo)
        private void btn_DXFcuboImportar_Click(object sender, EventArgs e)
        {
            startCuboDXF = rectangles.Count;
            if (cargarDXF(@"cubo.dxf", Color.SkyBlue))
            {
                endCuboDXF = rectangles.Count;
                btn_DXFcuboImportar.Enabled = false;
                btn_DXFcuboTrasladar.Enabled = true;
                btn_DXFcuboRotarX.Enabled = true;
                btn_DXFcuboRotarY.Enabled = true;
                btn_DXFcuboRotarZ.Enabled = true;
                btn_DXFcuboEscalar.Enabled = true;

                //calcular baricentro:
                baricentroCuboDXF[0] = 0;
                baricentroCuboDXF[1] = 0;
                baricentroCuboDXF[2] = 0;
                for (int item = startCuboDXF; item < endCuboDXF; item++)
                {
                    Rectangle r = rectangles[item];
                    baricentroCuboDXF[0] += r.points[0][0] + r.points[1][0] + r.points[2][0] + r.points[3][0];
                    baricentroCuboDXF[1] += r.points[0][1] + r.points[1][1] + r.points[2][1] + r.points[3][1];
                    baricentroCuboDXF[2] += r.points[0][2] + r.points[1][2] + r.points[2][2] + r.points[3][2];
                }
                baricentroCuboDXF[0] /= (4 * (endCuboDXF - startCuboDXF));
                baricentroCuboDXF[1] /= (4 * (endCuboDXF - startCuboDXF));
                baricentroCuboDXF[2] /= (4 * (endCuboDXF - startCuboDXF));

                eyeX = (int)(baricentroCuboDXF[0] * (baricentroCuboDXF[0] / 4)) + 10;
                eyeY = (int)(baricentroCuboDXF[1] * (baricentroCuboDXF[1] / 4)) + 10;
                eyeZ = (int)(baricentroCuboDXF[2] * (baricentroCuboDXF[2] / 4)) + 10;
                actualizarValor();
            }
        }

        private void btn_DXFcuboTrasladar_Click(object sender, EventArgs e)
        {
            for (int item = startCuboDXF; item < endCuboDXF; item++)
            {
                Rectangle r = rectangles[item];
                r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(-baricentroCuboDXF[0], -baricentroCuboDXF[1], -baricentroCuboDXF[2]), r.matrix);
            }
            btn_DXFcuboTrasladar.Enabled = false;
            btn_DXFcuboPosInicial.Enabled = true;
        }

        private void btn_DXFcuboPosInicial_Click(object sender, EventArgs e)
        {
            for (int item = startCuboDXF; item < endCuboDXF; item++)
            {
                Rectangle r = rectangles[item];
                r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(baricentroCuboDXF[0], baricentroCuboDXF[1], baricentroCuboDXF[2]), r.matrix);
            }
            btn_DXFcuboTrasladar.Enabled = true;
            btn_DXFcuboPosInicial.Enabled = false;
        }

        private void btn_DXFcuboRotarX_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
                for (int item = startCuboDXF; item < endCuboDXF; item++)
                {
                    Rectangle r = rectangles[item];
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getRotX(new Decimal(Math.PI / 50)), r.matrix);
                }
            }
        }

        private void btn_DXFcuboRotarY_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
                for (int item = startCuboDXF; item < endCuboDXF; item++)
                {
                    Rectangle r = rectangles[item];
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getRotY(new Decimal(Math.PI / 50)), r.matrix);
                }
            }
        }

        private void btn_DXFcuboRotarZ_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
                for (int item = startCuboDXF; item < endCuboDXF; item++)
                {
                    Rectangle r = rectangles[item];
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getRotZ(new Decimal(Math.PI / 50)), r.matrix);
                }
            }
        } 

        private void btn_DXFcuboEscalar_Click(object sender, EventArgs e)
        {
            for (int item = startCuboDXF; item < endCuboDXF; item++)
            {
                Rectangle r = rectangles[item];
                if(btn_DXFcuboTrasladar.Enabled == true)
                {
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(-baricentroCuboDXF[0], -baricentroCuboDXF[1], -baricentroCuboDXF[2]), r.matrix);
                }
                r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getScale(2, 2, 2), r.matrix);
                if (btn_DXFcuboTrasladar.Enabled == true)
                {
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(baricentroCuboDXF[0], baricentroCuboDXF[1], baricentroCuboDXF[2]), r.matrix);
                }
            }
        }
        #endregion

        #region Punto 2 (Algoritmo cubo)
        private void btn_cuboAlgoritmoCrear_Click(object sender, EventArgs e)
        {
            int tam = 30;
            Rectangle r;
            startCuboAlgoritmo = rectangles.Count;

            /* Cara 1 */
            r = new Rectangle();
            r.points[1][1] = tam;
            r.points[2][0] = tam;
            r.points[2][1] = tam;
            r.points[3][0] = tam;
            r.color = Color.Gold;
            rectangles.Add(r);

            /* Cara 2 */
            r = new Rectangle();
            r.points[0][1] = tam;
            r.points[1][0] = tam;
            r.points[1][1] = tam;
            r.points[2][0] = tam;
            r.points[2][1] = tam;
            r.points[2][2] = tam;
            r.points[3][1] = tam;
            r.points[3][2] = tam;
            r.color = Color.Gold;
            rectangles.Add(r);

            /* Cara 3 */
            r = new Rectangle();
            r.points[0][2] = tam;
            r.points[1][1] = tam;
            r.points[1][2] = tam;
            r.points[2][0] = tam;
            r.points[2][1] = tam;
            r.points[2][2] = tam;
            r.points[3][0] = tam;
            r.points[3][2] = tam;
            r.color = Color.Gold;
            rectangles.Add(r);
            
            /* Cara 4 */
            r = new Rectangle();
            r.points[1][0] = tam;
            r.points[2][0] = tam;
            r.points[2][2] = tam;
            r.points[3][2] = tam;
            r.color = Color.Gold;
            rectangles.Add(r);

            /* Cara 5 */
            r = new Rectangle();
            r.points[0][0] = tam;
            r.points[1][0] = tam;
            r.points[1][2] = tam;
            r.points[2][0] = tam;
            r.points[2][1] = tam;
            r.points[2][2] = tam;
            r.points[3][0] = tam;
            r.points[3][1] = tam;
            r.color = Color.Gold;
            rectangles.Add(r);

            /* Cara 6 */
            r = new Rectangle();
            r.points[1][2] = tam;
            r.points[2][1] = tam;
            r.points[2][2] = tam;
            r.points[3][1] = tam;
            r.color = Color.Gold;
            rectangles.Add(r);

            endCuboAlgoritmo = rectangles.Count;
            btn_cuboAlgoritmoCrear.Enabled = false;
            btn_cuboAlgoritmoTrasladar.Enabled = true;
            btn_cuboAlgoritmoRotarX.Enabled = true;
            btn_cuboAlgoritmoRotarY.Enabled = true;
            btn_cuboAlgoritmoRotarZ.Enabled = true;
            btn_cuboAlgoritmoEscalar.Enabled = true;

            //calcular baricentro:
            baricentroCuboAlgoritmo[0] = 0;
            baricentroCuboAlgoritmo[1] = 0;
            baricentroCuboAlgoritmo[2] = 0;
            for (int item = startCuboAlgoritmo; item < endCuboAlgoritmo; item++)
            {
                r = rectangles[item];
                baricentroCuboAlgoritmo[0] += r.points[0][0] + r.points[1][0] + r.points[2][0] + r.points[3][0];
                baricentroCuboAlgoritmo[1] += r.points[0][1] + r.points[1][1] + r.points[2][1] + r.points[3][1];
                baricentroCuboAlgoritmo[2] += r.points[0][2] + r.points[1][2] + r.points[2][2] + r.points[3][2];
            }
            baricentroCuboAlgoritmo[0] /= (4 * (endCuboAlgoritmo - startCuboAlgoritmo));
            baricentroCuboAlgoritmo[1] /= (4 * (endCuboAlgoritmo - startCuboAlgoritmo));
            baricentroCuboAlgoritmo[2] /= (4 * (endCuboAlgoritmo - startCuboAlgoritmo));

            eyeX = (int)(baricentroCuboAlgoritmo[0] * (baricentroCuboAlgoritmo[0] / 4)) + 10;
            eyeY = (int)(baricentroCuboAlgoritmo[1] * (baricentroCuboAlgoritmo[1] / 4)) + 10;
            eyeZ = (int)(baricentroCuboAlgoritmo[2] * (baricentroCuboAlgoritmo[2] / 4)) + 10;
            actualizarValor();
        }

        private void btn_cuboAlgoritmoTrasladar_Click(object sender, EventArgs e)
        {
            for (int item = startCuboAlgoritmo; item < endCuboAlgoritmo; item++)
            {
                Rectangle r = rectangles[item];
                r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(-baricentroCuboAlgoritmo[0], -baricentroCuboAlgoritmo[1], -baricentroCuboAlgoritmo[2]), r.matrix);
            }
            btn_cuboAlgoritmoTrasladar.Enabled = false;
            btn_cuboAlgoritmoPosInicial.Enabled = true;
        }

        private void btn_cuboAlgoritmoPosInicial_Click(object sender, EventArgs e)
        {
            for (int item = startCuboAlgoritmo; item < endCuboAlgoritmo; item++)
            {
                Rectangle r = rectangles[item];
                r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(baricentroCuboAlgoritmo[0], baricentroCuboAlgoritmo[1], baricentroCuboAlgoritmo[2]), r.matrix);
            }
            btn_cuboAlgoritmoTrasladar.Enabled = true;
            btn_cuboAlgoritmoPosInicial.Enabled = false;
        }

        private void btn_cuboAlgoritmoRotarX_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
                for (int item = startCuboAlgoritmo; item < endCuboAlgoritmo; item++)
                {
                    Rectangle r = rectangles[item];
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getRotX(new Decimal(Math.PI / 50)), r.matrix);
                }
            }
        }

        private void btn_cuboAlgoritmoRotarY_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
                for (int item = startCuboAlgoritmo; item < endCuboAlgoritmo; item++)
                {
                    Rectangle r = rectangles[item];
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getRotY(new Decimal(Math.PI / 50)), r.matrix);
                }
            }
        }

        private void btn_cuboAlgoritmoRotarZ_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
                for (int item = startCuboAlgoritmo; item < endCuboAlgoritmo; item++)
                {
                    Rectangle r = rectangles[item];
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getRotZ(new Decimal(Math.PI / 50)), r.matrix);
                }
            }
        }

        private void btn_cuboAlgoritmoEscalar_Click(object sender, EventArgs e)
        {
            for (int item = startCuboAlgoritmo; item < endCuboAlgoritmo; item++)
            {
                Rectangle r = rectangles[item];
                if (btn_cuboAlgoritmoTrasladar.Enabled == true)
                {
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(-baricentroCuboAlgoritmo[0], -baricentroCuboAlgoritmo[1], -baricentroCuboAlgoritmo[2]), r.matrix);
                }
                r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getScale(2, 2, 2), r.matrix);
                if (btn_cuboAlgoritmoTrasladar.Enabled == true)
                {
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(baricentroCuboAlgoritmo[0], baricentroCuboAlgoritmo[1], baricentroCuboAlgoritmo[2]), r.matrix);
                }
            }
        }
        #endregion

        #region Punto 3 (DXF figura)
        private void btn_figuraDXFImportar_Click(object sender, EventArgs e)
        {
            startFiguraDXF = rectangles.Count;
            if (cargarDXF(@"a3dchair.dxf", Color.Silver))
            {
                endFiguraDXF = rectangles.Count;
                btn_figuraDXFImportar.Enabled = false;
                btn_figuraDXFTrasladar.Enabled = true;
                btn_figuraDXFRotarX.Enabled = true;
                btn_figuraDXFRotarY.Enabled = true;
                btn_figuraDXFRotarZ.Enabled = true;
                btn_figuraDXFEscalar.Enabled = true;

                //calcular baricentro:
                baricentroFiguraDXF[0] = 0;
                baricentroFiguraDXF[1] = 0;
                baricentroFiguraDXF[2] = 0;
                for (int item = startFiguraDXF; item < endFiguraDXF; item++)
                {
                    Rectangle r = rectangles[item];
                    baricentroFiguraDXF[0] += r.points[0][0] + r.points[1][0] + r.points[2][0] + r.points[3][0];
                    baricentroFiguraDXF[1] += r.points[0][1] + r.points[1][1] + r.points[2][1] + r.points[3][1];
                    baricentroFiguraDXF[2] += r.points[0][2] + r.points[1][2] + r.points[2][2] + r.points[3][2];
                }
                baricentroFiguraDXF[0] /= (4 * (endFiguraDXF - startFiguraDXF));
                baricentroFiguraDXF[1] /= (4 * (endFiguraDXF - startFiguraDXF));
                baricentroFiguraDXF[2] /= (4 * (endFiguraDXF - startFiguraDXF));

                eyeX = (int)(baricentroFiguraDXF[0] * (baricentroFiguraDXF[0] / 4)) + 10;
                eyeY = (int)(baricentroFiguraDXF[1] * (baricentroFiguraDXF[1] / 4)) + 10;
                eyeZ = (int)(baricentroFiguraDXF[2] * (baricentroFiguraDXF[2] / 4)) + 10;
                actualizarValor();
            }
        }

        private void btn_figuraDXFTrasladar_Click(object sender, EventArgs e)
        {
            for (int item = startFiguraDXF; item < endFiguraDXF; item++)
            {
                Rectangle r = rectangles[item];
                r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(-baricentroFiguraDXF[0], -baricentroFiguraDXF[1], -baricentroFiguraDXF[2]), r.matrix);
            }
            btn_figuraDXFTrasladar.Enabled = false;
            btn_figuraDXFPosInicial.Enabled = true;
        }

        private void btn_figuraDXFPosInicial_Click(object sender, EventArgs e)
        {
            for (int item = startFiguraDXF; item < endFiguraDXF; item++)
            {
                Rectangle r = rectangles[item];
                r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(baricentroFiguraDXF[0], baricentroFiguraDXF[1], baricentroFiguraDXF[2]), r.matrix);
            }
            btn_figuraDXFTrasladar.Enabled = true;
            btn_figuraDXFPosInicial.Enabled = false;
        }

        private void btn_figuraDXFRotarX_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
                for (int item = startFiguraDXF; item < endFiguraDXF; item++)
                {
                    Rectangle r = rectangles[item];
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getRotX(new Decimal(Math.PI / 50)), r.matrix);
                }
            }
        }

        private void btn_figuraDXFRotarY_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
                for (int item = startFiguraDXF; item < endFiguraDXF; item++)
                {
                    Rectangle r = rectangles[item];
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getRotY(new Decimal(Math.PI / 50)), r.matrix);
                }
            }
        }

        private void btn_figuraDXFRotarZ_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
                for (int item = startFiguraDXF; item < endFiguraDXF; item++)
                {
                    Rectangle r = rectangles[item];
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getRotZ(new Decimal(Math.PI / 50)), r.matrix);
                }
            }
        }

        private void btn_figuraDXFEscalar_Click(object sender, EventArgs e)
        {
            for (int item = startFiguraDXF; item < endFiguraDXF; item++)
            {
                Rectangle r = rectangles[item];
                if (btn_figuraDXFTrasladar.Enabled == true)
                {
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(-baricentroFiguraDXF[0], -baricentroFiguraDXF[1], -baricentroFiguraDXF[2]), r.matrix);
                }
                r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getScale(2, 2, 2), r.matrix);
                if (btn_figuraDXFTrasladar.Enabled == true)
                {
                    r.matrix = FactoryMatrix.xMxM(FactoryMatrix.getTrans(baricentroFiguraDXF[0], baricentroFiguraDXF[1], baricentroFiguraDXF[2]), r.matrix);
                }
            }
        }
        #endregion


        #region Trabajo practico 3 (flechas, botones y sus efectos)
        private void lineGenerator(float width, Color color, int x1, int y1, int z1, int x2, int y2, int z2)
        {
            Line temp = new Line();

            temp.from[0] = x1;
            temp.from[1] = y1;
            temp.from[2] = z1;
            temp.to[0] = x2;
            temp.to[1] = y2;
            temp.to[2] = z2;
            temp.color = color;
            temp.width = width;
            lines.Add(temp);
        }

        private void generarFlechas()
        {
            lineGenerator(1, Color.Yellow, -100, 0, 0, 100, 0, 0);
            lineGenerator(1, Color.Yellow, -100, 0, 0, -90, 0, 5);
            lineGenerator(1, Color.Yellow, -100, 0, 0, -90, 0, -5);
            lineGenerator(1, Color.Yellow, 100, 0, 0, 90, 0, 5);
            lineGenerator(1, Color.Yellow, 100, 0, 0, 90, 0, -5);

            lineGenerator(1, Color.Red, 0, -100, 0, 0, 100, 0);
            lineGenerator(1, Color.Red, 0, -100, 0, 5, -90, 0);
            lineGenerator(1, Color.Red, 0, -100, 0, -5, -90, 0);
            lineGenerator(1, Color.Red, 0, 100, 0, 5, 90, 0);
            lineGenerator(1, Color.Red, 0, 100, 0, -5, 90, 0);

            lineGenerator(1, Color.Blue, 0, 0, -100, 0, 0, 100);
            lineGenerator(1, Color.Blue, 0, 0, -100, 0, 5, -90);
            lineGenerator(1, Color.Blue, 0, 0, -100, 0, -5, -90);
            lineGenerator(1, Color.Blue, 0, 0, 100, 0, 5, 90);
            lineGenerator(1, Color.Blue, 0, 0, 100, 0, -5, 90);
        }

        private void btn_xIzq_Click(object sender, EventArgs e)
        {
            eyeX += 10;
            actualizarValor();
        }

        private void btn_xDer_Click(object sender, EventArgs e)
        {
            eyeX -= 10;
            actualizarValor();
        }

        private void btn_yIzq_Click(object sender, EventArgs e)
        {
            eyeY += 10;
            actualizarValor();
        }

        private void btn_yDer_Click(object sender, EventArgs e)
        {
            eyeY -= 10;
            actualizarValor();
        }

        private void btn_zIzq_Click(object sender, EventArgs e)
        {
            eyeZ += 10;
            actualizarValor();
        }

        private void btn_zDer_Click(object sender, EventArgs e)
        {
            eyeZ -= 10;
            actualizarValor();
        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            eyeX = 100;
            eyeY = 100;
            eyeZ = 100;
            actualizarValor();
        }

        private void actualizarValor()
        {
            lbl_valorX.Text = eyeX.ToString();
            lbl_valorY.Text = eyeY.ToString();
            lbl_valorZ.Text = eyeZ.ToString();
        }

        private void btn_efecto1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                eyeX -= 5;
                actualizarValor();
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
            }
        }

        private void btn_efecto2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                eyeY -= 5;
                actualizarValor();
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
            }
        }

        private void btn_efecto3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                eyeZ -= 5;
                actualizarValor();
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
            }
        }

        private void btn_efecto4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (eyeX > 0)
                    eyeX -= 5;
                else
                    eyeX += 5;

                if (eyeY > 0)
                    eyeY -= 5;
                else
                    eyeY += 5;

                if (eyeZ > 0)
                    eyeZ -= 5;
                else
                    eyeZ += 5;
                actualizarValor();
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
            }
        }

        private void btn_efecto5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (eyeX > 0)
                    eyeX += 5;
                else
                    eyeX -= 5;

                if (eyeY > 0)
                    eyeY += 5;
                else
                    eyeY -= 5;

                if (eyeZ > 0)
                    eyeZ += 5;
                else
                    eyeZ -= 5;
                actualizarValor();
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
            }
        }

        private void btn_efecto6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                eyeX -= 10;
                eyeY -= 10;
                actualizarValor();
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
            }
        }

        private void btn_efecto7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                eyeX -= 10;
                eyeZ -= 10;
                actualizarValor();
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
            }
        }

        private void btn_efecto8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                eyeY -= 10;
                eyeZ -= 10;
                actualizarValor();
                System.Threading.Thread.Sleep(velocidad);
                Application.DoEvents();
            }
        }

        private void btn_efecto9_Click(object sender, EventArgs e)
        {
            for (int i = -100; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    lineGenerator(1, Color.Yellow, -100, 0, i, 100, 0, i);
                    lineGenerator(1, Color.Yellow, i, 0, -100, i, 0, 100);
                }
            }
            btn_efecto9.Enabled = false;
        }

        private void btn_efecto10_Click(object sender, EventArgs e)
        {
            for (int i = -100; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    lineGenerator(1, Color.Red, i, -100, 0, i, 100, 0);
                    lineGenerator(1, Color.Red, -100, i, 0, 100, i, 0);
                }
            }
            btn_efecto10.Enabled = false;
        }

        private void btn_efecto11_Click(object sender, EventArgs e)
        {
            for (int i = -100; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    lineGenerator(1, Color.Blue, 0, i, -100, 0, i, 100);
                    lineGenerator(1, Color.Blue, 0, -100, i, 0, 100, i);
                }
            }
            btn_efecto11.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_AcercaDe from = new Form_AcercaDe();
            from.ShowDialog();
        }
        #endregion
    }
}