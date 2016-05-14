namespace Traslacion_rotacion_OpenGL
{
    partial class Traslacion_rotacion_OpenGL
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Traslacion_rotacion_OpenGL));
            this.gl = new OpenTK.GLControl();
            this.btn_xDer = new System.Windows.Forms.Button();
            this.btn_xIzq = new System.Windows.Forms.Button();
            this.btn_yIzq = new System.Windows.Forms.Button();
            this.btn_yDer = new System.Windows.Forms.Button();
            this.btn_zIzq = new System.Windows.Forms.Button();
            this.btn_zDer = new System.Windows.Forms.Button();
            this.btn_restaurar = new System.Windows.Forms.Button();
            this.lbl_acercaDe = new System.Windows.Forms.Label();
            this.gbox_coordenadas = new System.Windows.Forms.GroupBox();
            this.lbl_valorZ = new System.Windows.Forms.Label();
            this.lbl_valorY = new System.Windows.Forms.Label();
            this.lbl_valorX = new System.Windows.Forms.Label();
            this.lbl_z = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lbl_x = new System.Windows.Forms.Label();
            this.btn_efecto1 = new System.Windows.Forms.Button();
            this.gbox_efectos = new System.Windows.Forms.GroupBox();
            this.btn_efecto11 = new System.Windows.Forms.Button();
            this.btn_efecto10 = new System.Windows.Forms.Button();
            this.btn_efecto9 = new System.Windows.Forms.Button();
            this.btn_efecto6 = new System.Windows.Forms.Button();
            this.btn_efecto3 = new System.Windows.Forms.Button();
            this.btn_efecto8 = new System.Windows.Forms.Button();
            this.btn_efecto2 = new System.Windows.Forms.Button();
            this.btn_efecto7 = new System.Windows.Forms.Button();
            this.btn_efecto4 = new System.Windows.Forms.Button();
            this.btn_efecto5 = new System.Windows.Forms.Button();
            this.tmrRedraw = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbox_dxfCubo = new System.Windows.Forms.GroupBox();
            this.btn_DXFcuboEscalar = new System.Windows.Forms.Button();
            this.btn_DXFcuboTrasladar = new System.Windows.Forms.Button();
            this.btn_DXFcuboRotarZ = new System.Windows.Forms.Button();
            this.btn_DXFcuboRotarY = new System.Windows.Forms.Button();
            this.btn_DXFcuboRotarX = new System.Windows.Forms.Button();
            this.btn_DXFcuboImportar = new System.Windows.Forms.Button();
            this.gbox_cuboAlgoritmo = new System.Windows.Forms.GroupBox();
            this.btn_cuboAlgoritmoEscalar = new System.Windows.Forms.Button();
            this.btn_cuboAlgoritmoTrasladar = new System.Windows.Forms.Button();
            this.btn_cuboAlgoritmoRotarZ = new System.Windows.Forms.Button();
            this.btn_cuboAlgoritmoRotarY = new System.Windows.Forms.Button();
            this.btn_cuboAlgoritmoRotarX = new System.Windows.Forms.Button();
            this.btn_cuboAlgoritmoCrear = new System.Windows.Forms.Button();
            this.gbox_figuraDXF = new System.Windows.Forms.GroupBox();
            this.btn_figuraDXFEscalar = new System.Windows.Forms.Button();
            this.btn_figuraDXFTrasladar = new System.Windows.Forms.Button();
            this.btn_figuraDXFRotarZ = new System.Windows.Forms.Button();
            this.btn_figuraDXFRotarY = new System.Windows.Forms.Button();
            this.btn_figuraDXFRotarX = new System.Windows.Forms.Button();
            this.btn_figuraDXFImportar = new System.Windows.Forms.Button();
            this.nmrUpDown_velocidad = new System.Windows.Forms.NumericUpDown();
            this.gBox_velocidad = new System.Windows.Forms.GroupBox();
            this.lbl_velocidad = new System.Windows.Forms.Label();
            this.btn_figuraDXFPosInicial = new System.Windows.Forms.Button();
            this.btn_DXFcuboPosInicial = new System.Windows.Forms.Button();
            this.btn_cuboAlgoritmoPosInicial = new System.Windows.Forms.Button();
            this.gbox_coordenadas.SuspendLayout();
            this.gbox_efectos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbox_dxfCubo.SuspendLayout();
            this.gbox_cuboAlgoritmo.SuspendLayout();
            this.gbox_figuraDXF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDown_velocidad)).BeginInit();
            this.gBox_velocidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // gl
            // 
            this.gl.BackColor = System.Drawing.Color.Black;
            this.gl.Location = new System.Drawing.Point(12, 38);
            this.gl.Name = "gl";
            this.gl.Size = new System.Drawing.Size(731, 381);
            this.gl.TabIndex = 0;
            this.gl.VSync = false;
            this.gl.Load += new System.EventHandler(this.gl_Load);
            this.gl.Paint += new System.Windows.Forms.PaintEventHandler(this.gl_Paint);
            // 
            // btn_xDer
            // 
            this.btn_xDer.BackColor = System.Drawing.Color.Transparent;
            this.btn_xDer.Location = new System.Drawing.Point(93, 425);
            this.btn_xDer.Name = "btn_xDer";
            this.btn_xDer.Size = new System.Drawing.Size(75, 23);
            this.btn_xDer.TabIndex = 4;
            this.btn_xDer.Text = "X =>";
            this.btn_xDer.UseVisualStyleBackColor = false;
            this.btn_xDer.Click += new System.EventHandler(this.btn_xDer_Click);
            // 
            // btn_xIzq
            // 
            this.btn_xIzq.BackColor = System.Drawing.Color.Transparent;
            this.btn_xIzq.Location = new System.Drawing.Point(12, 425);
            this.btn_xIzq.Name = "btn_xIzq";
            this.btn_xIzq.Size = new System.Drawing.Size(75, 23);
            this.btn_xIzq.TabIndex = 3;
            this.btn_xIzq.Text = "<= X";
            this.btn_xIzq.UseVisualStyleBackColor = false;
            this.btn_xIzq.Click += new System.EventHandler(this.btn_xIzq_Click);
            // 
            // btn_yIzq
            // 
            this.btn_yIzq.BackColor = System.Drawing.Color.Transparent;
            this.btn_yIzq.Location = new System.Drawing.Point(297, 425);
            this.btn_yIzq.Name = "btn_yIzq";
            this.btn_yIzq.Size = new System.Drawing.Size(75, 23);
            this.btn_yIzq.TabIndex = 5;
            this.btn_yIzq.Text = "<= Y";
            this.btn_yIzq.UseVisualStyleBackColor = false;
            this.btn_yIzq.Click += new System.EventHandler(this.btn_yIzq_Click);
            // 
            // btn_yDer
            // 
            this.btn_yDer.BackColor = System.Drawing.Color.Transparent;
            this.btn_yDer.Location = new System.Drawing.Point(378, 425);
            this.btn_yDer.Name = "btn_yDer";
            this.btn_yDer.Size = new System.Drawing.Size(75, 23);
            this.btn_yDer.TabIndex = 6;
            this.btn_yDer.Text = "Y =>";
            this.btn_yDer.UseVisualStyleBackColor = false;
            this.btn_yDer.Click += new System.EventHandler(this.btn_yDer_Click);
            // 
            // btn_zIzq
            // 
            this.btn_zIzq.BackColor = System.Drawing.Color.Transparent;
            this.btn_zIzq.Location = new System.Drawing.Point(587, 425);
            this.btn_zIzq.Name = "btn_zIzq";
            this.btn_zIzq.Size = new System.Drawing.Size(75, 23);
            this.btn_zIzq.TabIndex = 7;
            this.btn_zIzq.Text = "<= Z";
            this.btn_zIzq.UseVisualStyleBackColor = false;
            this.btn_zIzq.Click += new System.EventHandler(this.btn_zIzq_Click);
            // 
            // btn_zDer
            // 
            this.btn_zDer.BackColor = System.Drawing.Color.Transparent;
            this.btn_zDer.Location = new System.Drawing.Point(668, 425);
            this.btn_zDer.Name = "btn_zDer";
            this.btn_zDer.Size = new System.Drawing.Size(75, 23);
            this.btn_zDer.TabIndex = 8;
            this.btn_zDer.Text = "Z =>";
            this.btn_zDer.UseVisualStyleBackColor = false;
            this.btn_zDer.Click += new System.EventHandler(this.btn_zDer_Click);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.BackColor = System.Drawing.Color.Transparent;
            this.btn_restaurar.Location = new System.Drawing.Point(25, 91);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(75, 23);
            this.btn_restaurar.TabIndex = 9;
            this.btn_restaurar.Text = "Restaurar";
            this.btn_restaurar.UseVisualStyleBackColor = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // lbl_acercaDe
            // 
            this.lbl_acercaDe.AutoSize = true;
            this.lbl_acercaDe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_acercaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_acercaDe.Location = new System.Drawing.Point(722, 619);
            this.lbl_acercaDe.Name = "lbl_acercaDe";
            this.lbl_acercaDe.Size = new System.Drawing.Size(148, 13);
            this.lbl_acercaDe.TabIndex = 0;
            this.lbl_acercaDe.Text = "por Iván Daniel Villegas Rojas";
            // 
            // gbox_coordenadas
            // 
            this.gbox_coordenadas.BackColor = System.Drawing.Color.Transparent;
            this.gbox_coordenadas.Controls.Add(this.lbl_valorZ);
            this.gbox_coordenadas.Controls.Add(this.lbl_valorY);
            this.gbox_coordenadas.Controls.Add(this.lbl_valorX);
            this.gbox_coordenadas.Controls.Add(this.lbl_z);
            this.gbox_coordenadas.Controls.Add(this.lbl_y);
            this.gbox_coordenadas.Controls.Add(this.lbl_x);
            this.gbox_coordenadas.Controls.Add(this.btn_restaurar);
            this.gbox_coordenadas.Location = new System.Drawing.Point(751, 494);
            this.gbox_coordenadas.Name = "gbox_coordenadas";
            this.gbox_coordenadas.Size = new System.Drawing.Size(119, 122);
            this.gbox_coordenadas.TabIndex = 10;
            this.gbox_coordenadas.TabStop = false;
            this.gbox_coordenadas.Text = "Coordenadas del ojo";
            // 
            // lbl_valorZ
            // 
            this.lbl_valorZ.AutoSize = true;
            this.lbl_valorZ.ForeColor = System.Drawing.Color.Blue;
            this.lbl_valorZ.Location = new System.Drawing.Point(31, 66);
            this.lbl_valorZ.Name = "lbl_valorZ";
            this.lbl_valorZ.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorZ.TabIndex = 0;
            this.lbl_valorZ.Text = "-";
            // 
            // lbl_valorY
            // 
            this.lbl_valorY.AutoSize = true;
            this.lbl_valorY.ForeColor = System.Drawing.Color.Red;
            this.lbl_valorY.Location = new System.Drawing.Point(31, 42);
            this.lbl_valorY.Name = "lbl_valorY";
            this.lbl_valorY.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorY.TabIndex = 0;
            this.lbl_valorY.Text = "-";
            // 
            // lbl_valorX
            // 
            this.lbl_valorX.AutoSize = true;
            this.lbl_valorX.ForeColor = System.Drawing.Color.Orange;
            this.lbl_valorX.Location = new System.Drawing.Point(31, 19);
            this.lbl_valorX.Name = "lbl_valorX";
            this.lbl_valorX.Size = new System.Drawing.Size(10, 13);
            this.lbl_valorX.TabIndex = 0;
            this.lbl_valorX.Text = "-";
            // 
            // lbl_z
            // 
            this.lbl_z.AutoSize = true;
            this.lbl_z.ForeColor = System.Drawing.Color.Blue;
            this.lbl_z.Location = new System.Drawing.Point(7, 66);
            this.lbl_z.Name = "lbl_z";
            this.lbl_z.Size = new System.Drawing.Size(17, 13);
            this.lbl_z.TabIndex = 0;
            this.lbl_z.Text = "Z:";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.ForeColor = System.Drawing.Color.Red;
            this.lbl_y.Location = new System.Drawing.Point(7, 42);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(17, 13);
            this.lbl_y.TabIndex = 0;
            this.lbl_y.Text = "Y:";
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.ForeColor = System.Drawing.Color.Orange;
            this.lbl_x.Location = new System.Drawing.Point(7, 20);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(17, 13);
            this.lbl_x.TabIndex = 0;
            this.lbl_x.Text = "X:";
            // 
            // btn_efecto1
            // 
            this.btn_efecto1.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto1.Location = new System.Drawing.Point(6, 19);
            this.btn_efecto1.Name = "btn_efecto1";
            this.btn_efecto1.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto1.TabIndex = 10;
            this.btn_efecto1.Text = "Efecto X";
            this.btn_efecto1.UseVisualStyleBackColor = false;
            this.btn_efecto1.Click += new System.EventHandler(this.btn_efecto1_Click);
            // 
            // gbox_efectos
            // 
            this.gbox_efectos.BackColor = System.Drawing.Color.Transparent;
            this.gbox_efectos.Controls.Add(this.btn_efecto11);
            this.gbox_efectos.Controls.Add(this.btn_efecto10);
            this.gbox_efectos.Controls.Add(this.btn_efecto9);
            this.gbox_efectos.Controls.Add(this.btn_efecto6);
            this.gbox_efectos.Controls.Add(this.btn_efecto3);
            this.gbox_efectos.Controls.Add(this.btn_efecto8);
            this.gbox_efectos.Controls.Add(this.btn_efecto2);
            this.gbox_efectos.Controls.Add(this.btn_efecto7);
            this.gbox_efectos.Controls.Add(this.btn_efecto1);
            this.gbox_efectos.Location = new System.Drawing.Point(751, 38);
            this.gbox_efectos.Name = "gbox_efectos";
            this.gbox_efectos.Size = new System.Drawing.Size(117, 311);
            this.gbox_efectos.TabIndex = 10;
            this.gbox_efectos.TabStop = false;
            this.gbox_efectos.Text = "Efectos";
            // 
            // btn_efecto11
            // 
            this.btn_efecto11.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto11.Location = new System.Drawing.Point(6, 273);
            this.btn_efecto11.Name = "btn_efecto11";
            this.btn_efecto11.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto11.TabIndex = 18;
            this.btn_efecto11.Text = "Pared Z";
            this.btn_efecto11.UseVisualStyleBackColor = false;
            this.btn_efecto11.Click += new System.EventHandler(this.btn_efecto11_Click);
            // 
            // btn_efecto10
            // 
            this.btn_efecto10.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto10.Location = new System.Drawing.Point(6, 244);
            this.btn_efecto10.Name = "btn_efecto10";
            this.btn_efecto10.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto10.TabIndex = 17;
            this.btn_efecto10.Text = "Pared Y";
            this.btn_efecto10.UseVisualStyleBackColor = false;
            this.btn_efecto10.Click += new System.EventHandler(this.btn_efecto10_Click);
            // 
            // btn_efecto9
            // 
            this.btn_efecto9.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto9.Location = new System.Drawing.Point(6, 215);
            this.btn_efecto9.Name = "btn_efecto9";
            this.btn_efecto9.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto9.TabIndex = 16;
            this.btn_efecto9.Text = "Pared X";
            this.btn_efecto9.UseVisualStyleBackColor = false;
            this.btn_efecto9.Click += new System.EventHandler(this.btn_efecto9_Click);
            // 
            // btn_efecto6
            // 
            this.btn_efecto6.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto6.Location = new System.Drawing.Point(6, 116);
            this.btn_efecto6.Name = "btn_efecto6";
            this.btn_efecto6.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto6.TabIndex = 13;
            this.btn_efecto6.Text = "Efecto Giro XY";
            this.btn_efecto6.UseVisualStyleBackColor = false;
            this.btn_efecto6.Click += new System.EventHandler(this.btn_efecto6_Click);
            // 
            // btn_efecto3
            // 
            this.btn_efecto3.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto3.Location = new System.Drawing.Point(6, 77);
            this.btn_efecto3.Name = "btn_efecto3";
            this.btn_efecto3.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto3.TabIndex = 12;
            this.btn_efecto3.Text = "Efecto Z";
            this.btn_efecto3.UseVisualStyleBackColor = false;
            this.btn_efecto3.Click += new System.EventHandler(this.btn_efecto3_Click);
            // 
            // btn_efecto8
            // 
            this.btn_efecto8.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto8.Location = new System.Drawing.Point(5, 174);
            this.btn_efecto8.Name = "btn_efecto8";
            this.btn_efecto8.Size = new System.Drawing.Size(103, 23);
            this.btn_efecto8.TabIndex = 15;
            this.btn_efecto8.Text = "Efecto Giro YZ";
            this.btn_efecto8.UseVisualStyleBackColor = false;
            this.btn_efecto8.Click += new System.EventHandler(this.btn_efecto8_Click);
            // 
            // btn_efecto2
            // 
            this.btn_efecto2.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto2.Location = new System.Drawing.Point(6, 48);
            this.btn_efecto2.Name = "btn_efecto2";
            this.btn_efecto2.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto2.TabIndex = 11;
            this.btn_efecto2.Text = "Efecto Y";
            this.btn_efecto2.UseVisualStyleBackColor = false;
            this.btn_efecto2.Click += new System.EventHandler(this.btn_efecto2_Click);
            // 
            // btn_efecto7
            // 
            this.btn_efecto7.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto7.Location = new System.Drawing.Point(6, 145);
            this.btn_efecto7.Name = "btn_efecto7";
            this.btn_efecto7.Size = new System.Drawing.Size(102, 23);
            this.btn_efecto7.TabIndex = 14;
            this.btn_efecto7.Text = "Efecto Giro XZ";
            this.btn_efecto7.UseVisualStyleBackColor = false;
            this.btn_efecto7.Click += new System.EventHandler(this.btn_efecto7_Click);
            // 
            // btn_efecto4
            // 
            this.btn_efecto4.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto4.Location = new System.Drawing.Point(88, 9);
            this.btn_efecto4.Name = "btn_efecto4";
            this.btn_efecto4.Size = new System.Drawing.Size(70, 23);
            this.btn_efecto4.TabIndex = 2;
            this.btn_efecto4.Text = "Aumentar";
            this.btn_efecto4.UseVisualStyleBackColor = false;
            this.btn_efecto4.Click += new System.EventHandler(this.btn_efecto4_Click);
            // 
            // btn_efecto5
            // 
            this.btn_efecto5.BackColor = System.Drawing.Color.Transparent;
            this.btn_efecto5.Location = new System.Drawing.Point(12, 9);
            this.btn_efecto5.Name = "btn_efecto5";
            this.btn_efecto5.Size = new System.Drawing.Size(70, 23);
            this.btn_efecto5.TabIndex = 1;
            this.btn_efecto5.Text = "Disminuir";
            this.btn_efecto5.UseVisualStyleBackColor = false;
            this.btn_efecto5.Click += new System.EventHandler(this.btn_efecto5_Click);
            // 
            // tmrRedraw
            // 
            this.tmrRedraw.Enabled = true;
            this.tmrRedraw.Interval = 5;
            this.tmrRedraw.Tick += new System.EventHandler(this.tmrRedraw_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Traslacion_rotacion_OpenGL.Properties.Resources.Boton;
            this.pictureBox1.Location = new System.Drawing.Point(764, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 33);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // gbox_dxfCubo
            // 
            this.gbox_dxfCubo.BackColor = System.Drawing.Color.Transparent;
            this.gbox_dxfCubo.Controls.Add(this.btn_DXFcuboEscalar);
            this.gbox_dxfCubo.Controls.Add(this.btn_DXFcuboPosInicial);
            this.gbox_dxfCubo.Controls.Add(this.btn_DXFcuboTrasladar);
            this.gbox_dxfCubo.Controls.Add(this.btn_DXFcuboRotarZ);
            this.gbox_dxfCubo.Controls.Add(this.btn_DXFcuboRotarY);
            this.gbox_dxfCubo.Controls.Add(this.btn_DXFcuboRotarX);
            this.gbox_dxfCubo.Controls.Add(this.btn_DXFcuboImportar);
            this.gbox_dxfCubo.Location = new System.Drawing.Point(11, 454);
            this.gbox_dxfCubo.Name = "gbox_dxfCubo";
            this.gbox_dxfCubo.Size = new System.Drawing.Size(730, 50);
            this.gbox_dxfCubo.TabIndex = 12;
            this.gbox_dxfCubo.TabStop = false;
            this.gbox_dxfCubo.Text = "Cubo DXF";
            // 
            // btn_DXFcuboEscalar
            // 
            this.btn_DXFcuboEscalar.BackColor = System.Drawing.Color.Transparent;
            this.btn_DXFcuboEscalar.Enabled = false;
            this.btn_DXFcuboEscalar.Location = new System.Drawing.Point(386, 19);
            this.btn_DXFcuboEscalar.Name = "btn_DXFcuboEscalar";
            this.btn_DXFcuboEscalar.Size = new System.Drawing.Size(68, 23);
            this.btn_DXFcuboEscalar.TabIndex = 21;
            this.btn_DXFcuboEscalar.Text = "Escalar";
            this.btn_DXFcuboEscalar.UseVisualStyleBackColor = false;
            this.btn_DXFcuboEscalar.Click += new System.EventHandler(this.btn_DXFcuboEscalar_Click);
            // 
            // btn_DXFcuboTrasladar
            // 
            this.btn_DXFcuboTrasladar.BackColor = System.Drawing.Color.Transparent;
            this.btn_DXFcuboTrasladar.Enabled = false;
            this.btn_DXFcuboTrasladar.Location = new System.Drawing.Point(114, 19);
            this.btn_DXFcuboTrasladar.Name = "btn_DXFcuboTrasladar";
            this.btn_DXFcuboTrasladar.Size = new System.Drawing.Size(114, 23);
            this.btn_DXFcuboTrasladar.TabIndex = 20;
            this.btn_DXFcuboTrasladar.Text = "Trasladar al Origen";
            this.btn_DXFcuboTrasladar.UseVisualStyleBackColor = false;
            this.btn_DXFcuboTrasladar.Click += new System.EventHandler(this.btn_DXFcuboTrasladar_Click);
            // 
            // btn_DXFcuboRotarZ
            // 
            this.btn_DXFcuboRotarZ.BackColor = System.Drawing.Color.Transparent;
            this.btn_DXFcuboRotarZ.Enabled = false;
            this.btn_DXFcuboRotarZ.Location = new System.Drawing.Point(648, 19);
            this.btn_DXFcuboRotarZ.Name = "btn_DXFcuboRotarZ";
            this.btn_DXFcuboRotarZ.Size = new System.Drawing.Size(68, 23);
            this.btn_DXFcuboRotarZ.TabIndex = 24;
            this.btn_DXFcuboRotarZ.Text = "Rotar Z";
            this.btn_DXFcuboRotarZ.UseVisualStyleBackColor = false;
            this.btn_DXFcuboRotarZ.Click += new System.EventHandler(this.btn_DXFcuboRotarZ_Click);
            // 
            // btn_DXFcuboRotarY
            // 
            this.btn_DXFcuboRotarY.BackColor = System.Drawing.Color.Transparent;
            this.btn_DXFcuboRotarY.Enabled = false;
            this.btn_DXFcuboRotarY.Location = new System.Drawing.Point(574, 19);
            this.btn_DXFcuboRotarY.Name = "btn_DXFcuboRotarY";
            this.btn_DXFcuboRotarY.Size = new System.Drawing.Size(68, 23);
            this.btn_DXFcuboRotarY.TabIndex = 23;
            this.btn_DXFcuboRotarY.Text = "Rotar Y";
            this.btn_DXFcuboRotarY.UseVisualStyleBackColor = false;
            this.btn_DXFcuboRotarY.Click += new System.EventHandler(this.btn_DXFcuboRotarY_Click);
            // 
            // btn_DXFcuboRotarX
            // 
            this.btn_DXFcuboRotarX.BackColor = System.Drawing.Color.Transparent;
            this.btn_DXFcuboRotarX.Enabled = false;
            this.btn_DXFcuboRotarX.Location = new System.Drawing.Point(500, 19);
            this.btn_DXFcuboRotarX.Name = "btn_DXFcuboRotarX";
            this.btn_DXFcuboRotarX.Size = new System.Drawing.Size(68, 23);
            this.btn_DXFcuboRotarX.TabIndex = 22;
            this.btn_DXFcuboRotarX.Text = "Rotar X";
            this.btn_DXFcuboRotarX.UseVisualStyleBackColor = false;
            this.btn_DXFcuboRotarX.Click += new System.EventHandler(this.btn_DXFcuboRotarX_Click);
            // 
            // btn_DXFcuboImportar
            // 
            this.btn_DXFcuboImportar.BackColor = System.Drawing.Color.Transparent;
            this.btn_DXFcuboImportar.Location = new System.Drawing.Point(6, 19);
            this.btn_DXFcuboImportar.Name = "btn_DXFcuboImportar";
            this.btn_DXFcuboImportar.Size = new System.Drawing.Size(68, 23);
            this.btn_DXFcuboImportar.TabIndex = 19;
            this.btn_DXFcuboImportar.Text = "Importar";
            this.btn_DXFcuboImportar.UseVisualStyleBackColor = false;
            this.btn_DXFcuboImportar.Click += new System.EventHandler(this.btn_DXFcuboImportar_Click);
            // 
            // gbox_cuboAlgoritmo
            // 
            this.gbox_cuboAlgoritmo.BackColor = System.Drawing.Color.Transparent;
            this.gbox_cuboAlgoritmo.Controls.Add(this.btn_cuboAlgoritmoEscalar);
            this.gbox_cuboAlgoritmo.Controls.Add(this.btn_cuboAlgoritmoPosInicial);
            this.gbox_cuboAlgoritmo.Controls.Add(this.btn_cuboAlgoritmoTrasladar);
            this.gbox_cuboAlgoritmo.Controls.Add(this.btn_cuboAlgoritmoRotarZ);
            this.gbox_cuboAlgoritmo.Controls.Add(this.btn_cuboAlgoritmoRotarY);
            this.gbox_cuboAlgoritmo.Controls.Add(this.btn_cuboAlgoritmoRotarX);
            this.gbox_cuboAlgoritmo.Controls.Add(this.btn_cuboAlgoritmoCrear);
            this.gbox_cuboAlgoritmo.Location = new System.Drawing.Point(12, 510);
            this.gbox_cuboAlgoritmo.Name = "gbox_cuboAlgoritmo";
            this.gbox_cuboAlgoritmo.Size = new System.Drawing.Size(731, 50);
            this.gbox_cuboAlgoritmo.TabIndex = 12;
            this.gbox_cuboAlgoritmo.TabStop = false;
            this.gbox_cuboAlgoritmo.Text = "Cubo Algoritmo";
            // 
            // btn_cuboAlgoritmoEscalar
            // 
            this.btn_cuboAlgoritmoEscalar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cuboAlgoritmoEscalar.Enabled = false;
            this.btn_cuboAlgoritmoEscalar.Location = new System.Drawing.Point(385, 19);
            this.btn_cuboAlgoritmoEscalar.Name = "btn_cuboAlgoritmoEscalar";
            this.btn_cuboAlgoritmoEscalar.Size = new System.Drawing.Size(68, 23);
            this.btn_cuboAlgoritmoEscalar.TabIndex = 27;
            this.btn_cuboAlgoritmoEscalar.Text = "Escalar";
            this.btn_cuboAlgoritmoEscalar.UseVisualStyleBackColor = false;
            this.btn_cuboAlgoritmoEscalar.Click += new System.EventHandler(this.btn_cuboAlgoritmoEscalar_Click);
            // 
            // btn_cuboAlgoritmoTrasladar
            // 
            this.btn_cuboAlgoritmoTrasladar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cuboAlgoritmoTrasladar.Enabled = false;
            this.btn_cuboAlgoritmoTrasladar.Location = new System.Drawing.Point(113, 19);
            this.btn_cuboAlgoritmoTrasladar.Name = "btn_cuboAlgoritmoTrasladar";
            this.btn_cuboAlgoritmoTrasladar.Size = new System.Drawing.Size(114, 23);
            this.btn_cuboAlgoritmoTrasladar.TabIndex = 26;
            this.btn_cuboAlgoritmoTrasladar.Text = "Trasladar al Origen";
            this.btn_cuboAlgoritmoTrasladar.UseVisualStyleBackColor = false;
            this.btn_cuboAlgoritmoTrasladar.Click += new System.EventHandler(this.btn_cuboAlgoritmoTrasladar_Click);
            // 
            // btn_cuboAlgoritmoRotarZ
            // 
            this.btn_cuboAlgoritmoRotarZ.BackColor = System.Drawing.Color.Transparent;
            this.btn_cuboAlgoritmoRotarZ.Enabled = false;
            this.btn_cuboAlgoritmoRotarZ.Location = new System.Drawing.Point(647, 19);
            this.btn_cuboAlgoritmoRotarZ.Name = "btn_cuboAlgoritmoRotarZ";
            this.btn_cuboAlgoritmoRotarZ.Size = new System.Drawing.Size(68, 23);
            this.btn_cuboAlgoritmoRotarZ.TabIndex = 30;
            this.btn_cuboAlgoritmoRotarZ.Text = "Rotar Z";
            this.btn_cuboAlgoritmoRotarZ.UseVisualStyleBackColor = false;
            this.btn_cuboAlgoritmoRotarZ.Click += new System.EventHandler(this.btn_cuboAlgoritmoRotarZ_Click);
            // 
            // btn_cuboAlgoritmoRotarY
            // 
            this.btn_cuboAlgoritmoRotarY.BackColor = System.Drawing.Color.Transparent;
            this.btn_cuboAlgoritmoRotarY.Enabled = false;
            this.btn_cuboAlgoritmoRotarY.Location = new System.Drawing.Point(573, 19);
            this.btn_cuboAlgoritmoRotarY.Name = "btn_cuboAlgoritmoRotarY";
            this.btn_cuboAlgoritmoRotarY.Size = new System.Drawing.Size(68, 23);
            this.btn_cuboAlgoritmoRotarY.TabIndex = 29;
            this.btn_cuboAlgoritmoRotarY.Text = "Rotar Y";
            this.btn_cuboAlgoritmoRotarY.UseVisualStyleBackColor = false;
            this.btn_cuboAlgoritmoRotarY.Click += new System.EventHandler(this.btn_cuboAlgoritmoRotarY_Click);
            // 
            // btn_cuboAlgoritmoRotarX
            // 
            this.btn_cuboAlgoritmoRotarX.BackColor = System.Drawing.Color.Transparent;
            this.btn_cuboAlgoritmoRotarX.Enabled = false;
            this.btn_cuboAlgoritmoRotarX.Location = new System.Drawing.Point(499, 19);
            this.btn_cuboAlgoritmoRotarX.Name = "btn_cuboAlgoritmoRotarX";
            this.btn_cuboAlgoritmoRotarX.Size = new System.Drawing.Size(68, 23);
            this.btn_cuboAlgoritmoRotarX.TabIndex = 28;
            this.btn_cuboAlgoritmoRotarX.Text = "Rotar X";
            this.btn_cuboAlgoritmoRotarX.UseVisualStyleBackColor = false;
            this.btn_cuboAlgoritmoRotarX.Click += new System.EventHandler(this.btn_cuboAlgoritmoRotarX_Click);
            // 
            // btn_cuboAlgoritmoCrear
            // 
            this.btn_cuboAlgoritmoCrear.BackColor = System.Drawing.Color.Transparent;
            this.btn_cuboAlgoritmoCrear.Location = new System.Drawing.Point(6, 19);
            this.btn_cuboAlgoritmoCrear.Name = "btn_cuboAlgoritmoCrear";
            this.btn_cuboAlgoritmoCrear.Size = new System.Drawing.Size(68, 23);
            this.btn_cuboAlgoritmoCrear.TabIndex = 25;
            this.btn_cuboAlgoritmoCrear.Text = "Crear";
            this.btn_cuboAlgoritmoCrear.UseVisualStyleBackColor = false;
            this.btn_cuboAlgoritmoCrear.Click += new System.EventHandler(this.btn_cuboAlgoritmoCrear_Click);
            // 
            // gbox_figuraDXF
            // 
            this.gbox_figuraDXF.BackColor = System.Drawing.Color.Transparent;
            this.gbox_figuraDXF.Controls.Add(this.btn_figuraDXFEscalar);
            this.gbox_figuraDXF.Controls.Add(this.btn_figuraDXFPosInicial);
            this.gbox_figuraDXF.Controls.Add(this.btn_figuraDXFTrasladar);
            this.gbox_figuraDXF.Controls.Add(this.btn_figuraDXFRotarZ);
            this.gbox_figuraDXF.Controls.Add(this.btn_figuraDXFRotarY);
            this.gbox_figuraDXF.Controls.Add(this.btn_figuraDXFRotarX);
            this.gbox_figuraDXF.Controls.Add(this.btn_figuraDXFImportar);
            this.gbox_figuraDXF.Location = new System.Drawing.Point(12, 566);
            this.gbox_figuraDXF.Name = "gbox_figuraDXF";
            this.gbox_figuraDXF.Size = new System.Drawing.Size(732, 50);
            this.gbox_figuraDXF.TabIndex = 12;
            this.gbox_figuraDXF.TabStop = false;
            this.gbox_figuraDXF.Text = "Figura DXF";
            // 
            // btn_figuraDXFEscalar
            // 
            this.btn_figuraDXFEscalar.BackColor = System.Drawing.Color.Transparent;
            this.btn_figuraDXFEscalar.Enabled = false;
            this.btn_figuraDXFEscalar.Location = new System.Drawing.Point(385, 19);
            this.btn_figuraDXFEscalar.Name = "btn_figuraDXFEscalar";
            this.btn_figuraDXFEscalar.Size = new System.Drawing.Size(68, 23);
            this.btn_figuraDXFEscalar.TabIndex = 33;
            this.btn_figuraDXFEscalar.Text = "Escalar";
            this.btn_figuraDXFEscalar.UseVisualStyleBackColor = false;
            this.btn_figuraDXFEscalar.Click += new System.EventHandler(this.btn_figuraDXFEscalar_Click);
            // 
            // btn_figuraDXFTrasladar
            // 
            this.btn_figuraDXFTrasladar.BackColor = System.Drawing.Color.Transparent;
            this.btn_figuraDXFTrasladar.Enabled = false;
            this.btn_figuraDXFTrasladar.Location = new System.Drawing.Point(113, 19);
            this.btn_figuraDXFTrasladar.Name = "btn_figuraDXFTrasladar";
            this.btn_figuraDXFTrasladar.Size = new System.Drawing.Size(114, 23);
            this.btn_figuraDXFTrasladar.TabIndex = 32;
            this.btn_figuraDXFTrasladar.Text = "Trasladar al Origen";
            this.btn_figuraDXFTrasladar.UseVisualStyleBackColor = false;
            this.btn_figuraDXFTrasladar.Click += new System.EventHandler(this.btn_figuraDXFTrasladar_Click);
            // 
            // btn_figuraDXFRotarZ
            // 
            this.btn_figuraDXFRotarZ.BackColor = System.Drawing.Color.Transparent;
            this.btn_figuraDXFRotarZ.Enabled = false;
            this.btn_figuraDXFRotarZ.Location = new System.Drawing.Point(647, 19);
            this.btn_figuraDXFRotarZ.Name = "btn_figuraDXFRotarZ";
            this.btn_figuraDXFRotarZ.Size = new System.Drawing.Size(68, 23);
            this.btn_figuraDXFRotarZ.TabIndex = 36;
            this.btn_figuraDXFRotarZ.Text = "Rotar Z";
            this.btn_figuraDXFRotarZ.UseVisualStyleBackColor = false;
            this.btn_figuraDXFRotarZ.Click += new System.EventHandler(this.btn_figuraDXFRotarZ_Click);
            // 
            // btn_figuraDXFRotarY
            // 
            this.btn_figuraDXFRotarY.BackColor = System.Drawing.Color.Transparent;
            this.btn_figuraDXFRotarY.Enabled = false;
            this.btn_figuraDXFRotarY.Location = new System.Drawing.Point(573, 19);
            this.btn_figuraDXFRotarY.Name = "btn_figuraDXFRotarY";
            this.btn_figuraDXFRotarY.Size = new System.Drawing.Size(68, 23);
            this.btn_figuraDXFRotarY.TabIndex = 35;
            this.btn_figuraDXFRotarY.Text = "Rotar Y";
            this.btn_figuraDXFRotarY.UseVisualStyleBackColor = false;
            this.btn_figuraDXFRotarY.Click += new System.EventHandler(this.btn_figuraDXFRotarY_Click);
            // 
            // btn_figuraDXFRotarX
            // 
            this.btn_figuraDXFRotarX.BackColor = System.Drawing.Color.Transparent;
            this.btn_figuraDXFRotarX.Enabled = false;
            this.btn_figuraDXFRotarX.Location = new System.Drawing.Point(499, 19);
            this.btn_figuraDXFRotarX.Name = "btn_figuraDXFRotarX";
            this.btn_figuraDXFRotarX.Size = new System.Drawing.Size(68, 23);
            this.btn_figuraDXFRotarX.TabIndex = 34;
            this.btn_figuraDXFRotarX.Text = "Rotar X";
            this.btn_figuraDXFRotarX.UseVisualStyleBackColor = false;
            this.btn_figuraDXFRotarX.Click += new System.EventHandler(this.btn_figuraDXFRotarX_Click);
            // 
            // btn_figuraDXFImportar
            // 
            this.btn_figuraDXFImportar.BackColor = System.Drawing.Color.Transparent;
            this.btn_figuraDXFImportar.Location = new System.Drawing.Point(6, 19);
            this.btn_figuraDXFImportar.Name = "btn_figuraDXFImportar";
            this.btn_figuraDXFImportar.Size = new System.Drawing.Size(68, 23);
            this.btn_figuraDXFImportar.TabIndex = 31;
            this.btn_figuraDXFImportar.Text = "Importar";
            this.btn_figuraDXFImportar.UseVisualStyleBackColor = false;
            this.btn_figuraDXFImportar.Click += new System.EventHandler(this.btn_figuraDXFImportar_Click);
            // 
            // nmrUpDown_velocidad
            // 
            this.nmrUpDown_velocidad.Location = new System.Drawing.Point(9, 52);
            this.nmrUpDown_velocidad.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmrUpDown_velocidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrUpDown_velocidad.Name = "nmrUpDown_velocidad";
            this.nmrUpDown_velocidad.Size = new System.Drawing.Size(100, 20);
            this.nmrUpDown_velocidad.TabIndex = 37;
            this.nmrUpDown_velocidad.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrUpDown_velocidad.ValueChanged += new System.EventHandler(this.nmrUpDown_velocidad_ValueChanged);
            // 
            // gBox_velocidad
            // 
            this.gBox_velocidad.Controls.Add(this.lbl_velocidad);
            this.gBox_velocidad.Controls.Add(this.nmrUpDown_velocidad);
            this.gBox_velocidad.Location = new System.Drawing.Point(750, 374);
            this.gBox_velocidad.Name = "gBox_velocidad";
            this.gBox_velocidad.Size = new System.Drawing.Size(118, 90);
            this.gBox_velocidad.TabIndex = 13;
            this.gBox_velocidad.TabStop = false;
            this.gBox_velocidad.Text = "Velocidad";
            // 
            // lbl_velocidad
            // 
            this.lbl_velocidad.AutoSize = true;
            this.lbl_velocidad.Location = new System.Drawing.Point(6, 22);
            this.lbl_velocidad.Name = "lbl_velocidad";
            this.lbl_velocidad.Size = new System.Drawing.Size(91, 13);
            this.lbl_velocidad.TabIndex = 38;
            this.lbl_velocidad.Text = "Elige tu velocidad";
            // 
            // btn_figuraDXFPosInicial
            // 
            this.btn_figuraDXFPosInicial.BackColor = System.Drawing.Color.Transparent;
            this.btn_figuraDXFPosInicial.Enabled = false;
            this.btn_figuraDXFPosInicial.Location = new System.Drawing.Point(233, 19);
            this.btn_figuraDXFPosInicial.Name = "btn_figuraDXFPosInicial";
            this.btn_figuraDXFPosInicial.Size = new System.Drawing.Size(114, 23);
            this.btn_figuraDXFPosInicial.TabIndex = 32;
            this.btn_figuraDXFPosInicial.Text = "Posicion inicial";
            this.btn_figuraDXFPosInicial.UseVisualStyleBackColor = false;
            this.btn_figuraDXFPosInicial.Click += new System.EventHandler(this.btn_figuraDXFPosInicial_Click);
            // 
            // btn_DXFcuboPosInicial
            // 
            this.btn_DXFcuboPosInicial.BackColor = System.Drawing.Color.Transparent;
            this.btn_DXFcuboPosInicial.Enabled = false;
            this.btn_DXFcuboPosInicial.Location = new System.Drawing.Point(234, 19);
            this.btn_DXFcuboPosInicial.Name = "btn_DXFcuboPosInicial";
            this.btn_DXFcuboPosInicial.Size = new System.Drawing.Size(114, 23);
            this.btn_DXFcuboPosInicial.TabIndex = 20;
            this.btn_DXFcuboPosInicial.Text = "Posicion inicial";
            this.btn_DXFcuboPosInicial.UseVisualStyleBackColor = false;
            this.btn_DXFcuboPosInicial.Click += new System.EventHandler(this.btn_DXFcuboPosInicial_Click);
            // 
            // btn_cuboAlgoritmoPosInicial
            // 
            this.btn_cuboAlgoritmoPosInicial.BackColor = System.Drawing.Color.Transparent;
            this.btn_cuboAlgoritmoPosInicial.Enabled = false;
            this.btn_cuboAlgoritmoPosInicial.Location = new System.Drawing.Point(233, 19);
            this.btn_cuboAlgoritmoPosInicial.Name = "btn_cuboAlgoritmoPosInicial";
            this.btn_cuboAlgoritmoPosInicial.Size = new System.Drawing.Size(114, 23);
            this.btn_cuboAlgoritmoPosInicial.TabIndex = 26;
            this.btn_cuboAlgoritmoPosInicial.Text = "Posicion inicial";
            this.btn_cuboAlgoritmoPosInicial.UseVisualStyleBackColor = false;
            this.btn_cuboAlgoritmoPosInicial.Click += new System.EventHandler(this.btn_cuboAlgoritmoPosInicial_Click);
            // 
            // Traslacion_rotacion_OpenGL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 637);
            this.Controls.Add(this.gBox_velocidad);
            this.Controls.Add(this.gbox_figuraDXF);
            this.Controls.Add(this.gbox_cuboAlgoritmo);
            this.Controls.Add(this.gbox_dxfCubo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbox_efectos);
            this.Controls.Add(this.gbox_coordenadas);
            this.Controls.Add(this.lbl_acercaDe);
            this.Controls.Add(this.btn_zDer);
            this.Controls.Add(this.btn_efecto5);
            this.Controls.Add(this.btn_yIzq);
            this.Controls.Add(this.btn_zIzq);
            this.Controls.Add(this.btn_xIzq);
            this.Controls.Add(this.btn_efecto4);
            this.Controls.Add(this.btn_yDer);
            this.Controls.Add(this.btn_xDer);
            this.Controls.Add(this.gl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Traslacion_rotacion_OpenGL";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flechas en OpenGL";
            this.gbox_coordenadas.ResumeLayout(false);
            this.gbox_coordenadas.PerformLayout();
            this.gbox_efectos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbox_dxfCubo.ResumeLayout(false);
            this.gbox_cuboAlgoritmo.ResumeLayout(false);
            this.gbox_figuraDXF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrUpDown_velocidad)).EndInit();
            this.gBox_velocidad.ResumeLayout(false);
            this.gBox_velocidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl gl;
        private System.Windows.Forms.Button btn_xDer;
        private System.Windows.Forms.Button btn_xIzq;
        private System.Windows.Forms.Button btn_yIzq;
        private System.Windows.Forms.Button btn_yDer;
        private System.Windows.Forms.Button btn_zIzq;
        private System.Windows.Forms.Button btn_zDer;
        private System.Windows.Forms.Button btn_restaurar;
        private System.Windows.Forms.Label lbl_acercaDe;
        private System.Windows.Forms.GroupBox gbox_coordenadas;
        private System.Windows.Forms.Label lbl_z;
        private System.Windows.Forms.Label lbl_y;
        private System.Windows.Forms.Label lbl_x;
        private System.Windows.Forms.Label lbl_valorZ;
        private System.Windows.Forms.Label lbl_valorY;
        private System.Windows.Forms.Label lbl_valorX;
        private System.Windows.Forms.Button btn_efecto1;
        private System.Windows.Forms.GroupBox gbox_efectos;
        private System.Windows.Forms.Button btn_efecto3;
        private System.Windows.Forms.Button btn_efecto2;
        private System.Windows.Forms.Button btn_efecto6;
        private System.Windows.Forms.Button btn_efecto5;
        private System.Windows.Forms.Button btn_efecto4;
        private System.Windows.Forms.Button btn_efecto9;
        private System.Windows.Forms.Button btn_efecto8;
        private System.Windows.Forms.Button btn_efecto7;
        private System.Windows.Forms.Button btn_efecto11;
        private System.Windows.Forms.Button btn_efecto10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrRedraw;
        private System.Windows.Forms.GroupBox gbox_dxfCubo;
        private System.Windows.Forms.Button btn_DXFcuboImportar;
        private System.Windows.Forms.Button btn_DXFcuboEscalar;
        private System.Windows.Forms.Button btn_DXFcuboTrasladar;
        private System.Windows.Forms.Button btn_DXFcuboRotarX;
        private System.Windows.Forms.GroupBox gbox_cuboAlgoritmo;
        private System.Windows.Forms.Button btn_cuboAlgoritmoEscalar;
        private System.Windows.Forms.Button btn_cuboAlgoritmoRotarX;
        private System.Windows.Forms.Button btn_cuboAlgoritmoCrear;
        private System.Windows.Forms.Button btn_cuboAlgoritmoTrasladar;
        private System.Windows.Forms.GroupBox gbox_figuraDXF;
        private System.Windows.Forms.Button btn_figuraDXFEscalar;
        private System.Windows.Forms.Button btn_figuraDXFTrasladar;
        private System.Windows.Forms.Button btn_figuraDXFRotarX;
        private System.Windows.Forms.Button btn_figuraDXFImportar;
        private System.Windows.Forms.Button btn_DXFcuboRotarZ;
        private System.Windows.Forms.Button btn_DXFcuboRotarY;
        private System.Windows.Forms.Button btn_cuboAlgoritmoRotarZ;
        private System.Windows.Forms.Button btn_cuboAlgoritmoRotarY;
        private System.Windows.Forms.Button btn_figuraDXFRotarZ;
        private System.Windows.Forms.Button btn_figuraDXFRotarY;
        private System.Windows.Forms.NumericUpDown nmrUpDown_velocidad;
        private System.Windows.Forms.GroupBox gBox_velocidad;
        private System.Windows.Forms.Label lbl_velocidad;
        private System.Windows.Forms.Button btn_figuraDXFPosInicial;
        private System.Windows.Forms.Button btn_DXFcuboPosInicial;
        private System.Windows.Forms.Button btn_cuboAlgoritmoPosInicial;
    }
}

