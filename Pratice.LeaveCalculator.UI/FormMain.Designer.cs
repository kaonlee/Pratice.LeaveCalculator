namespace Pratice.LeaveCalculator.UI
{
	partial class LeaveCalculator
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if (disposing && ( components != null ))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			btnCalc =  new Button() ;
			textBoxEnd =  new TextBox() ;
			label2 =  new Label() ;
			label1 =  new Label() ;
			textBoxStart =  new TextBox() ;
			labelResult =  new Label() ;
			SuspendLayout();
			// 
			// btnCalc
			// 
			btnCalc.FlatStyle =  FlatStyle.Flat ;
			btnCalc.ImageAlign =  ContentAlignment.TopCenter ;
			btnCalc.Location =  new Point(72, 113) ;
			btnCalc.Name =  "btnCalc" ;
			btnCalc.Size =  new Size(75, 23) ;
			btnCalc.TabIndex =  0 ;
			btnCalc.Text =  "Calc ! " ;
			btnCalc.UseVisualStyleBackColor =  true ;
			btnCalc.Click +=  btnCalc_Click ;
			// 
			// textBoxEnd
			// 
			textBoxEnd.Location =  new Point(118, 71) ;
			textBoxEnd.Name =  "textBoxEnd" ;
			textBoxEnd.Size =  new Size(52, 23) ;
			textBoxEnd.TabIndex =  1 ;
			// 
			// label2
			// 
			label2.AutoSize =  true ;
			label2.Location =  new Point(118, 53) ;
			label2.Name =  "label2" ;
			label2.Size =  new Size(29, 15) ;
			label2.TabIndex =  4 ;
			label2.Text =  "End" ;
			// 
			// label1
			// 
			label1.AutoSize =  true ;
			label1.Location =  new Point(43, 53) ;
			label1.Name =  "label1" ;
			label1.Size =  new Size(33, 15) ;
			label1.TabIndex =  6 ;
			label1.Text =  "Start" ;
			// 
			// textBoxStart
			// 
			textBoxStart.Location =  new Point(43, 71) ;
			textBoxStart.Name =  "textBoxStart" ;
			textBoxStart.Size =  new Size(52, 23) ;
			textBoxStart.TabIndex =  5 ;
			// 
			// labelResult
			// 
			labelResult.AutoSize =  true ;
			labelResult.Location =  new Point(43, 162) ;
			labelResult.Name =  "labelResult" ;
			labelResult.Size =  new Size(41, 15) ;
			labelResult.TabIndex =  7 ;
			labelResult.Text =  "Result" ;
			// 
			// LeaveCalculator
			// 
			AcceptButton =  btnCalc ;
			AutoScaleDimensions =  new SizeF(7F, 15F) ;
			AutoScaleMode =  AutoScaleMode.Font ;
			BackColor =  SystemColors.ButtonFace ;
			ClientSize =  new Size(244, 249) ;
			Controls.Add(labelResult);
			Controls.Add(label1);
			Controls.Add(textBoxStart);
			Controls.Add(label2);
			Controls.Add(textBoxEnd);
			Controls.Add(btnCalc);
			Name =  "LeaveCalculator" ;
			Text =  "LeaveCalc" ;
			Load +=  LeaveCalculator_Load ;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnCalc;
		private TextBox textBoxEnd;
		private Label label2;
		private Label label1;
		private TextBox textBoxStart;
		private Label labelResult;
	}
}