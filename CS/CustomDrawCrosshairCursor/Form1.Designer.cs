﻿
namespace CustomDrawCrosshairCursor {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(50D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(34D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(55D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint(4D, new object[] {
            ((object)(77D))});
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView1 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel2 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint(1D, new object[] {
            ((object)(22D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint(2D, new object[] {
            ((object)(11D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint7 = new DevExpress.XtraCharts.SeriesPoint(3D, new object[] {
            ((object)(9D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint8 = new DevExpress.XtraCharts.SeriesPoint(4D, new object[] {
            ((object)(8D))});
            DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.CrosshairOptions.ShowArgumentLabels = true;
            this.chartControl1.CrosshairOptions.ShowValueLabels = true;
            this.chartControl1.CrosshairOptions.ShowValueLine = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            series1.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4});
            series1.View = splineSeriesView1;
            pointSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            series2.Label = pointSeriesLabel2;
            series2.Name = "Series 2";
            series2.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint5,
            seriesPoint6,
            seriesPoint7,
            seriesPoint8});
            series2.View = splineSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            sideBySideBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl1.Size = new System.Drawing.Size(480, 316);
            this.chartControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkEdit1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 63);
            this.panel1.TabIndex = 0;
            // 
            // checkEdit1
            // 
            this.checkEdit1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkEdit1.Location = new System.Drawing.Point(309, 0);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Custom Draw Crosshair Cursor";
            this.checkEdit1.Size = new System.Drawing.Size(171, 63);
            this.checkEdit1.TabIndex = 0;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.OnCheckEditCheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 379);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}

