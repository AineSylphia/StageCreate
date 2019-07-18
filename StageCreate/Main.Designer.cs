namespace StageCreate
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.StageLoad = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.tBInPath = new System.Windows.Forms.TextBox();
            this.cBItem = new System.Windows.Forms.ComboBox();
            this.lbItem = new System.Windows.Forms.Label();
            this.tBPosX = new System.Windows.Forms.TextBox();
            this.tBPosY = new System.Windows.Forms.TextBox();
            this.lbPosX = new System.Windows.Forms.Label();
            this.lbPosY = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.resultLBTop = new System.Windows.Forms.Label();
            this.cBModual = new System.Windows.Forms.ComboBox();
            this.lbSize = new System.Windows.Forms.Label();
            this.tBSize = new System.Windows.Forms.TextBox();
            this.tBMode = new System.Windows.Forms.TextBox();
            this.tBOutPath = new System.Windows.Forms.TextBox();
            this.lbModual = new System.Windows.Forms.Label();
            this.lbMode = new System.Windows.Forms.Label();
            this.tBNextStage = new System.Windows.Forms.TextBox();
            this.lbNextStage = new System.Windows.Forms.Label();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.btEdit = new System.Windows.Forms.Button();
            this.bTlistClear = new System.Windows.Forms.Button();
            this.btDraw = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.lbIndex = new System.Windows.Forms.Label();
            this.cBMode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StageLoad
            // 
            resources.ApplyResources(this.StageLoad, "StageLoad");
            this.StageLoad.Name = "StageLoad";
            this.StageLoad.UseVisualStyleBackColor = true;
            this.StageLoad.Click += new System.EventHandler(this.StageLoad_Click);
            // 
            // SaveButton
            // 
            resources.ApplyResources(this.SaveButton, "SaveButton");
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // tBInPath
            // 
            resources.ApplyResources(this.tBInPath, "tBInPath");
            this.tBInPath.Name = "tBInPath";
            // 
            // cBItem
            // 
            this.cBItem.FormattingEnabled = true;
            this.cBItem.Items.AddRange(new object[] {
            resources.GetString("cBItem.Items")});
            resources.ApplyResources(this.cBItem, "cBItem");
            this.cBItem.Name = "cBItem";
            this.cBItem.SelectedIndexChanged += new System.EventHandler(this.cBItem_SelectedIndexChanged);
            // 
            // lbItem
            // 
            resources.ApplyResources(this.lbItem, "lbItem");
            this.lbItem.Name = "lbItem";
            // 
            // tBPosX
            // 
            resources.ApplyResources(this.tBPosX, "tBPosX");
            this.tBPosX.Name = "tBPosX";
            // 
            // tBPosY
            // 
            resources.ApplyResources(this.tBPosY, "tBPosY");
            this.tBPosY.Name = "tBPosY";
            // 
            // lbPosX
            // 
            resources.ApplyResources(this.lbPosX, "lbPosX");
            this.lbPosX.Name = "lbPosX";
            // 
            // lbPosY
            // 
            resources.ApplyResources(this.lbPosY, "lbPosY");
            this.lbPosY.Name = "lbPosY";
            // 
            // ResultButton
            // 
            resources.ApplyResources(this.ResultButton, "ResultButton");
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // resultLBTop
            // 
            resources.ApplyResources(this.resultLBTop, "resultLBTop");
            this.resultLBTop.Name = "resultLBTop";
            // 
            // cBModual
            // 
            this.cBModual.FormattingEnabled = true;
            resources.ApplyResources(this.cBModual, "cBModual");
            this.cBModual.Name = "cBModual";
            // 
            // lbSize
            // 
            resources.ApplyResources(this.lbSize, "lbSize");
            this.lbSize.Name = "lbSize";
            // 
            // tBSize
            // 
            resources.ApplyResources(this.tBSize, "tBSize");
            this.tBSize.Name = "tBSize";
            // 
            // tBMode
            // 
            resources.ApplyResources(this.tBMode, "tBMode");
            this.tBMode.Name = "tBMode";
            // 
            // tBOutPath
            // 
            resources.ApplyResources(this.tBOutPath, "tBOutPath");
            this.tBOutPath.Name = "tBOutPath";
            // 
            // lbModual
            // 
            resources.ApplyResources(this.lbModual, "lbModual");
            this.lbModual.Name = "lbModual";
            // 
            // lbMode
            // 
            resources.ApplyResources(this.lbMode, "lbMode");
            this.lbMode.Name = "lbMode";
            // 
            // tBNextStage
            // 
            resources.ApplyResources(this.tBNextStage, "tBNextStage");
            this.tBNextStage.Name = "tBNextStage";
            // 
            // lbNextStage
            // 
            resources.ApplyResources(this.lbNextStage, "lbNextStage");
            this.lbNextStage.Name = "lbNextStage";
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxResult, "listBoxResult");
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxResult_MouseDoubleClick);
            // 
            // btEdit
            // 
            resources.ApplyResources(this.btEdit, "btEdit");
            this.btEdit.Name = "btEdit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // bTlistClear
            // 
            resources.ApplyResources(this.bTlistClear, "bTlistClear");
            this.bTlistClear.Name = "bTlistClear";
            this.bTlistClear.UseVisualStyleBackColor = true;
            this.bTlistClear.Click += new System.EventHandler(this.bTlistClear_Click);
            // 
            // btDraw
            // 
            resources.ApplyResources(this.btDraw, "btDraw");
            this.btDraw.Name = "btDraw";
            this.btDraw.UseVisualStyleBackColor = true;
            this.btDraw.Click += new System.EventHandler(this.btDraw_Click);
            // 
            // btDel
            // 
            resources.ApplyResources(this.btDel, "btDel");
            this.btDel.Name = "btDel";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // lbIndex
            // 
            resources.ApplyResources(this.lbIndex, "lbIndex");
            this.lbIndex.Name = "lbIndex";
            // 
            // cBMode
            // 
            this.cBMode.FormattingEnabled = true;
            resources.ApplyResources(this.cBMode, "cBMode");
            this.cBMode.Name = "cBMode";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cBMode);
            this.Controls.Add(this.lbIndex);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btDraw);
            this.Controls.Add(this.bTlistClear);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.lbNextStage);
            this.Controls.Add(this.tBNextStage);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.lbModual);
            this.Controls.Add(this.tBOutPath);
            this.Controls.Add(this.tBMode);
            this.Controls.Add(this.tBSize);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.cBModual);
            this.Controls.Add(this.resultLBTop);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.lbPosY);
            this.Controls.Add(this.lbPosX);
            this.Controls.Add(this.tBPosY);
            this.Controls.Add(this.tBPosX);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.cBItem);
            this.Controls.Add(this.tBInPath);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StageLoad);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StageLoad;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox tBInPath;
        private System.Windows.Forms.ComboBox cBItem;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.TextBox tBPosX;
        private System.Windows.Forms.TextBox tBPosY;
        private System.Windows.Forms.Label lbPosX;
        private System.Windows.Forms.Label lbPosY;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Label resultLBTop;
        private System.Windows.Forms.ComboBox cBModual;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.TextBox tBSize;
        private System.Windows.Forms.TextBox tBMode;
        private System.Windows.Forms.TextBox tBOutPath;
        private System.Windows.Forms.Label lbModual;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.TextBox tBNextStage;
        private System.Windows.Forms.Label lbNextStage;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button bTlistClear;
		private System.Windows.Forms.Button btDraw;
		private System.Windows.Forms.Button btDel;
		private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.ComboBox cBMode;
    }
}

