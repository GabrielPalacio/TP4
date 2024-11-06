namespace TP4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSimulacion = new DataGridView();
            btnSimular = new Button();
            txtRetorno = new TextBox();
            txtPrRetira = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtIntervaloB = new TextBox();
            txtIntervaloA = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtHasta = new TextBox();
            txtDesde = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtTiempo = new TextBox();
            txtIteraciones = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            cEvento = new DataGridViewTextBoxColumn();
            cReloj = new DataGridViewTextBoxColumn();
            cProximaLlegadaCliente = new DataGridViewTextBoxColumn();
            cRndSolicitud = new DataGridViewTextBoxColumn();
            cSolicitudCliente = new DataGridViewTextBoxColumn();
            cRndConsulta = new DataGridViewTextBoxColumn();
            cTiempoConsulta = new DataGridViewTextBoxColumn();
            cTiempoFinConsulta = new DataGridViewTextBoxColumn();
            cRndBusquedaLibro = new DataGridViewTextBoxColumn();
            cTiempoEntreBusquedaLibro = new DataGridViewTextBoxColumn();
            cTiempoFinBusquedaLibro = new DataGridViewTextBoxColumn();
            cRndDevolucionLibro = new DataGridViewTextBoxColumn();
            cTiempoDevolucionLibro = new DataGridViewTextBoxColumn();
            cTiempoFinDevolucionLibro = new DataGridViewTextBoxColumn();
            cRndUsoInstalacion = new DataGridViewTextBoxColumn();
            cUsaInstalacion = new DataGridViewTextBoxColumn();
            cTiempoFinUsoInstalacion = new DataGridViewTextBoxColumn();
            cEmpleadoUno = new DataGridViewTextBoxColumn();
            cEmpleadoDos = new DataGridViewTextBoxColumn();
            cCantidadClientesDentro = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSimulacion).BeginInit();
            SuspendLayout();
            // 
            // dgvSimulacion
            // 
            dgvSimulacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSimulacion.Columns.AddRange(new DataGridViewColumn[] { cEvento, cReloj, cProximaLlegadaCliente, cRndSolicitud, cSolicitudCliente, cRndConsulta, cTiempoConsulta, cTiempoFinConsulta, cRndBusquedaLibro, cTiempoEntreBusquedaLibro, cTiempoFinBusquedaLibro, cRndDevolucionLibro, cTiempoDevolucionLibro, cTiempoFinDevolucionLibro, cRndUsoInstalacion, cUsaInstalacion, cTiempoFinUsoInstalacion, cEmpleadoUno, cEmpleadoDos, cCantidadClientesDentro });
            dgvSimulacion.Location = new Point(10, 166);
            dgvSimulacion.Margin = new Padding(1);
            dgvSimulacion.Name = "dgvSimulacion";
            dgvSimulacion.RowHeadersWidth = 102;
            dgvSimulacion.Size = new Size(716, 191);
            dgvSimulacion.TabIndex = 0;
            dgvSimulacion.CellContentClick += dgvSimulacion_CellContentClick;
            // 
            // btnSimular
            // 
            btnSimular.Location = new Point(60, 128);
            btnSimular.Margin = new Padding(1);
            btnSimular.Name = "btnSimular";
            btnSimular.Size = new Size(77, 21);
            btnSimular.TabIndex = 1;
            btnSimular.Text = "Simular";
            btnSimular.UseVisualStyleBackColor = true;
            btnSimular.Click += btnSimular_Click;
            // 
            // txtRetorno
            // 
            txtRetorno.Location = new Point(698, 68);
            txtRetorno.Name = "txtRetorno";
            txtRetorno.Size = new Size(88, 23);
            txtRetorno.TabIndex = 35;
            txtRetorno.Text = "30";
            // 
            // txtPrRetira
            // 
            txtPrRetira.Location = new Point(698, 30);
            txtPrRetira.Name = "txtPrRetira";
            txtPrRetira.Size = new Size(88, 23);
            txtPrRetira.TabIndex = 34;
            txtPrRetira.Text = "60";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(603, 71);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 33;
            label7.Text = "Tiempo retorno";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(603, 33);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 32;
            label8.Text = "Pr de se Retira";
            // 
            // txtIntervaloB
            // 
            txtIntervaloB.Location = new Point(485, 68);
            txtIntervaloB.Name = "txtIntervaloB";
            txtIntervaloB.Size = new Size(100, 23);
            txtIntervaloB.TabIndex = 31;
            txtIntervaloB.Text = "5";
            // 
            // txtIntervaloA
            // 
            txtIntervaloA.Location = new Point(485, 33);
            txtIntervaloA.Name = "txtIntervaloA";
            txtIntervaloA.Size = new Size(100, 23);
            txtIntervaloA.TabIndex = 30;
            txtIntervaloA.Text = "2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 68);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 29;
            label5.Text = "Intervalo B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 36);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 28;
            label6.Text = "Intervalo A";
            // 
            // txtHasta
            // 
            txtHasta.Location = new Point(285, 68);
            txtHasta.Name = "txtHasta";
            txtHasta.Size = new Size(100, 23);
            txtHasta.TabIndex = 27;
            txtHasta.Text = "10000";
            // 
            // txtDesde
            // 
            txtDesde.Location = new Point(285, 30);
            txtDesde.Name = "txtDesde";
            txtDesde.Size = new Size(100, 23);
            txtDesde.TabIndex = 26;
            txtDesde.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 71);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 25;
            label3.Text = "Tiempo  Hasta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 33);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 24;
            label4.Text = "Tiempo Desde";
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(60, 68);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(100, 23);
            txtTiempo.TabIndex = 23;
            txtTiempo.Text = "10000";
            // 
            // txtIteraciones
            // 
            txtIteraciones.Location = new Point(60, 30);
            txtIteraciones.Name = "txtIteraciones";
            txtIteraciones.Size = new Size(100, 23);
            txtIteraciones.TabIndex = 22;
            txtIteraciones.Text = "10000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 71);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 21;
            label2.Text = "Tiempo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-10, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 20;
            label1.Text = "Iteraciones";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(438, 8);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 36;
            label9.Text = "Consulta";
            // 
            // cEvento
            // 
            cEvento.HeaderText = "Evento";
            cEvento.MinimumWidth = 12;
            cEvento.Name = "cEvento";
            cEvento.Width = 250;
            // 
            // cReloj
            // 
            cReloj.HeaderText = "Reloj";
            cReloj.MinimumWidth = 12;
            cReloj.Name = "cReloj";
            cReloj.Width = 250;
            // 
            // cProximaLlegadaCliente
            // 
            cProximaLlegadaCliente.HeaderText = "Proxima Llegada Cliente";
            cProximaLlegadaCliente.MinimumWidth = 12;
            cProximaLlegadaCliente.Name = "cProximaLlegadaCliente";
            cProximaLlegadaCliente.Width = 250;
            // 
            // cRndSolicitud
            // 
            cRndSolicitud.HeaderText = "RND Solicitud";
            cRndSolicitud.Name = "cRndSolicitud";
            // 
            // cSolicitudCliente
            // 
            cSolicitudCliente.HeaderText = "Solicitud Cliente";
            cSolicitudCliente.MinimumWidth = 12;
            cSolicitudCliente.Name = "cSolicitudCliente";
            cSolicitudCliente.Width = 250;
            // 
            // cRndConsulta
            // 
            cRndConsulta.HeaderText = "Rnd Consulta";
            cRndConsulta.MinimumWidth = 12;
            cRndConsulta.Name = "cRndConsulta";
            cRndConsulta.Width = 250;
            // 
            // cTiempoConsulta
            // 
            cTiempoConsulta.HeaderText = "Tiempo Consulta";
            cTiempoConsulta.MinimumWidth = 12;
            cTiempoConsulta.Name = "cTiempoConsulta";
            cTiempoConsulta.Width = 250;
            // 
            // cTiempoFinConsulta
            // 
            cTiempoFinConsulta.HeaderText = "Tiempo Fin Consulta";
            cTiempoFinConsulta.MinimumWidth = 12;
            cTiempoFinConsulta.Name = "cTiempoFinConsulta";
            cTiempoFinConsulta.Width = 250;
            // 
            // cRndBusquedaLibro
            // 
            cRndBusquedaLibro.HeaderText = "Rnd Busqueda Libro";
            cRndBusquedaLibro.MinimumWidth = 12;
            cRndBusquedaLibro.Name = "cRndBusquedaLibro";
            cRndBusquedaLibro.Width = 250;
            // 
            // cTiempoEntreBusquedaLibro
            // 
            cTiempoEntreBusquedaLibro.HeaderText = "Tiempo Entre Busqueda Libro";
            cTiempoEntreBusquedaLibro.MinimumWidth = 12;
            cTiempoEntreBusquedaLibro.Name = "cTiempoEntreBusquedaLibro";
            cTiempoEntreBusquedaLibro.Width = 250;
            // 
            // cTiempoFinBusquedaLibro
            // 
            cTiempoFinBusquedaLibro.HeaderText = "Tiempo Fin Busqueda Libro";
            cTiempoFinBusquedaLibro.MinimumWidth = 12;
            cTiempoFinBusquedaLibro.Name = "cTiempoFinBusquedaLibro";
            cTiempoFinBusquedaLibro.Width = 250;
            // 
            // cRndDevolucionLibro
            // 
            cRndDevolucionLibro.HeaderText = "Rnd Devolucion Libro";
            cRndDevolucionLibro.MinimumWidth = 12;
            cRndDevolucionLibro.Name = "cRndDevolucionLibro";
            cRndDevolucionLibro.Width = 250;
            // 
            // cTiempoDevolucionLibro
            // 
            cTiempoDevolucionLibro.HeaderText = "Tiempo Devolucion Libro";
            cTiempoDevolucionLibro.MinimumWidth = 12;
            cTiempoDevolucionLibro.Name = "cTiempoDevolucionLibro";
            cTiempoDevolucionLibro.Width = 250;
            // 
            // cTiempoFinDevolucionLibro
            // 
            cTiempoFinDevolucionLibro.HeaderText = "Tiempo Fin Devolucion Libro";
            cTiempoFinDevolucionLibro.MinimumWidth = 12;
            cTiempoFinDevolucionLibro.Name = "cTiempoFinDevolucionLibro";
            cTiempoFinDevolucionLibro.Width = 250;
            // 
            // cRndUsoInstalacion
            // 
            cRndUsoInstalacion.HeaderText = "Rnd Uso Instalacion";
            cRndUsoInstalacion.MinimumWidth = 12;
            cRndUsoInstalacion.Name = "cRndUsoInstalacion";
            cRndUsoInstalacion.Width = 250;
            // 
            // cUsaInstalacion
            // 
            cUsaInstalacion.HeaderText = "Usa Instalacion";
            cUsaInstalacion.MinimumWidth = 12;
            cUsaInstalacion.Name = "cUsaInstalacion";
            cUsaInstalacion.Width = 250;
            // 
            // cTiempoFinUsoInstalacion
            // 
            cTiempoFinUsoInstalacion.HeaderText = "Tiempo Fin Uso Instalacion";
            cTiempoFinUsoInstalacion.MinimumWidth = 12;
            cTiempoFinUsoInstalacion.Name = "cTiempoFinUsoInstalacion";
            cTiempoFinUsoInstalacion.Width = 250;
            // 
            // cEmpleadoUno
            // 
            cEmpleadoUno.HeaderText = "Empleado 1";
            cEmpleadoUno.MinimumWidth = 12;
            cEmpleadoUno.Name = "cEmpleadoUno";
            cEmpleadoUno.Width = 250;
            // 
            // cEmpleadoDos
            // 
            cEmpleadoDos.HeaderText = "Empleado 2";
            cEmpleadoDos.MinimumWidth = 12;
            cEmpleadoDos.Name = "cEmpleadoDos";
            cEmpleadoDos.Width = 250;
            // 
            // cCantidadClientesDentro
            // 
            cCantidadClientesDentro.HeaderText = "Cantidad Clientes Dentro";
            cCantidadClientesDentro.MinimumWidth = 12;
            cCantidadClientesDentro.Name = "cCantidadClientesDentro";
            cCantidadClientesDentro.Width = 250;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 387);
            Controls.Add(label9);
            Controls.Add(txtRetorno);
            Controls.Add(txtPrRetira);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtIntervaloB);
            Controls.Add(txtIntervaloA);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtHasta);
            Controls.Add(txtDesde);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtTiempo);
            Controls.Add(txtIteraciones);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSimular);
            Controls.Add(dgvSimulacion);
            Margin = new Padding(1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSimulacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSimulacion;
        private Button btnSimular;
        private TextBox txtRetorno;
        private TextBox txtPrRetira;
        private Label label7;
        private Label label8;
        private TextBox txtIntervaloB;
        private TextBox txtIntervaloA;
        private Label label5;
        private Label label6;
        private TextBox txtHasta;
        private TextBox txtDesde;
        private Label label3;
        private Label label4;
        private TextBox txtTiempo;
        private TextBox txtIteraciones;
        private Label label2;
        private Label label1;
        private Label label9;
        private DataGridViewTextBoxColumn cEvento;
        private DataGridViewTextBoxColumn cReloj;
        private DataGridViewTextBoxColumn cProximaLlegadaCliente;
        private DataGridViewTextBoxColumn cRndSolicitud;
        private DataGridViewTextBoxColumn cSolicitudCliente;
        private DataGridViewTextBoxColumn cRndConsulta;
        private DataGridViewTextBoxColumn cTiempoConsulta;
        private DataGridViewTextBoxColumn cTiempoFinConsulta;
        private DataGridViewTextBoxColumn cRndBusquedaLibro;
        private DataGridViewTextBoxColumn cTiempoEntreBusquedaLibro;
        private DataGridViewTextBoxColumn cTiempoFinBusquedaLibro;
        private DataGridViewTextBoxColumn cRndDevolucionLibro;
        private DataGridViewTextBoxColumn cTiempoDevolucionLibro;
        private DataGridViewTextBoxColumn cTiempoFinDevolucionLibro;
        private DataGridViewTextBoxColumn cRndUsoInstalacion;
        private DataGridViewTextBoxColumn cUsaInstalacion;
        private DataGridViewTextBoxColumn cTiempoFinUsoInstalacion;
        private DataGridViewTextBoxColumn cEmpleadoUno;
        private DataGridViewTextBoxColumn cEmpleadoDos;
        private DataGridViewTextBoxColumn cCantidadClientesDentro;
    }
}