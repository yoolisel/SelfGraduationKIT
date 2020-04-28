using SelfGraduationKIT.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinHttp;

namespace test
{
    public class Form1 : Form
    {
        private class Base64String
        {
            public static string Base64Encoding(string str)
            {
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(str));
            }

            public static string Base64Decoding(string str)
            {
                return Encoding.UTF8.GetString(Convert.FromBase64String(str));
            }
        }

        public int unida2 = 0;
        public double majsum2 = 0.0;
        public int[] fundasum = new int[7];
        public int fundasusum = 0;
        private WinHttpRequest WinHT = new WinHttpRequest();
        private IContainer components = (IContainer) null;
        public int bassum;
        public int unida1;
        public double sumsum1;
        public double majsum1;
        private Button button1;
        private TextBox ID;
        private TextBox PW;
        private Label studentnumber;
        private Label majnm;
        private Label maj2nm;
        private PictureBox pictureBox1;
        private Label name;
        private Label enterY;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listView1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private ListView listView2;
        private ColumnHeader columnHeader7;
        private ComboBox comboBox1;
        private ListView listView3;
        private ColumnHeader columnHeader8;
        private ListView listView4;
        private ColumnHeader columnHeader9;
        private ListView listView5;
        private ColumnHeader columnHeader10;
        private ListView listView6;
        private ColumnHeader columnHeader11;
        private ListView listView7;
        private ColumnHeader columnHeader12;
        private ListView listView8;
        private ColumnHeader columnHeader13;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private ListView listView9;
        private ColumnHeader columnHeader16;
        private ColumnHeader columnHeader14;
        private ListView listView10;
        private ColumnHeader columnHeader15;
        private Label label30;
        private Label label31;
        private ListView listView11;
        private ListView listView12;
        private ListView listView13;
        private ListView listView14;
        private Label label32;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ColumnHeader columnHeader20;
        private ColumnHeader columnHeader21;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;

        private void ID_Click(object sender, EventArgs e)
        {
            this.ID.Text = "";
        }

        private void PW_Click(object sender, EventArgs e)
        {
            this.PW.Text = "";
        }

        public Form1()
        {
            this.InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(350, 100);
            this.MinimumSize = new Size(350, 100);
            this.majnm.Text = "";
            this.maj2nm.Text = "";
            this.listView2.Visible = true;
            this.listView3.Visible = false;
            this.listView4.Visible = false;
            this.listView5.Visible = false;
            this.listView6.Visible = false;
            this.listView7.Visible = false;
            this.listView8.Visible = false;
        }

        string target(CallSite callsite, dynamic obj)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(obj));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = this.ID.Text;
            string text2 = this.PW.Text;
            // ISSUE: reference to a compiler-generated method
            this.WinHT.Open("Post", "https://nis.gnu.ac.kr/frame/sysUser.do", (object) true);
            // ISSUE: reference to a compiler-generated method
            this.WinHT.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            // ISSUE: reference to a compiler-generated method
            this.WinHT.SetRequestHeader("Referer", "https://nis.gnu.ac.kr/frame/sysUser.do");
            // ISSUE: reference to a compiler-generated method
            this.WinHT.Send((object) ("https://nis.gnu.ac.kr/frame/sysUser.do?logGb=1&tmpu=" +
                                      Form1.Base64String.Base64Encoding(text1) + "&tmpw=" +
                                      Form1.Base64String.Base64Encoding(text2) +
                                      "&AlgID=SEED&SessionRequestData=&userGroupGb=&mode=&userid=&password="));
            // ISSUE: reference to a compiler-generated method
            this.WinHT.WaitForResponse(Type.Missing);
            // ISSUE: reference to a compiler-generated method
            this.WinHT.Open("GET", "https://nis.gnu.ac.kr/frame/main.do", (object) true);
            // ISSUE: reference to a compiler-generated method
            this.WinHT.Send(Type.Missing);
            // ISSUE: reference to a compiler-generated method
            this.WinHT.WaitForResponse(Type.Missing);
            // ISSUE: reference to a compiler-generated field
            //if (Form1.\u003C\u003Eo__14.\u003C\u003Ep__1 == null)
            //{
            //  // ISSUE: reference to a compiler-generated field
            //  Form1.\u003C\u003Eo__14.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), typeof (Form1)));
            //}
            //// ISSUE: reference to a compiler-generated field
            //Func<CallSite, object, string> target = Form1.\u003C\u003Eo__14.\u003C\u003Ep__1.Target;
            //// ISSUE: reference to a compiler-generated field
            //CallSite<Func<CallSite, object, string>> p1 = Form1.\u003C\u003Eo__14.\u003C\u003Ep__1;
            //// ISSUE: reference to a compiler-generated field
            //if (Form1.\u003C\u003Eo__14.\u003C\u003Ep__0 == null)
            //{
            //  // ISSUE: reference to a compiler-generated field
            //  Form1.\u003C\u003Eo__14.\u003C\u003Ep__0 = CallSite<Func<CallSite, Encoding, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetString", (IEnumerable<Type>) null, typeof (Form1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            //  {
            //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
            //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            //  }));
            //}
            //// ISSUE: reference to a compiler-generated field
            //// ISSUE: reference to a compiler-generated field
            //object obj = Form1.\u003C\u003Eo__14.\u003C\u003Ep__0.Target((CallSite) Form1.\u003C\u003Eo__14.\u003C\u003Ep__0, Encoding.UTF8, this.WinHT.ResponseBody);
            if (target((CallSite) null, this.WinHT.ResponseBody).IndexOf("경상대학교") == -1)
            {
                int num1 = (int) MessageBox.Show("아이디 혹은 패스워드가 잘 못 입력되었습니다.", "경상대학교", MessageBoxButtons.OK);
            }
            else
            {
                int num2 = (int) MessageBox.Show("취득 결과를 종합한 데이터를 정리중입니다.", "경상대학교", MessageBoxButtons.OK);
                this.action();
                this.ID.Hide();
                this.PW.Hide();
                this.button1.Visible = false;
                this.MaximumSize = new Size(930, 650);
                this.Size = new Size(930, 630);
                this.MinimumSize = new Size(930, 650);
                this.pictureBox1.Visible = true;
                this.enterY.Visible = true;
                this.studentnumber.Visible = true;
                this.majnm.Visible = true;
                this.name.Visible = true;
                this.maj2nm.Visible = true;
            }
        }

        private void action()
        {
            // ISSUE: reference to a compiler-generated method
            this.WinHT.Open("GET", "https://nis.gnu.ac.kr/frame/help_student_cd.gnu?mode=doGetCount&sch_student_no=",
                (object) true);
            // ISSUE: reference to a compiler-generated method
            this.WinHT.Send(Type.Missing);
            // ISSUE: reference to a compiler-generated method
            this.WinHT.WaitForResponse(Type.Missing);
            // ISSUE: reference to a compiler-generated field
            //if (Form1.\u003C\u003Eo__15.\u003C\u003Ep__1 == null)
            //{
            //  // ISSUE: reference to a compiler-generated field
            //  Form1.\u003C\u003Eo__15.\u003C\u003Ep__1 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), typeof (Form1)));
            //}
            //// ISSUE: reference to a compiler-generated field
            //Func<CallSite, object, string> target1 = Form1.\u003C\u003Eo__15.\u003C\u003Ep__1.Target;
            //// ISSUE: reference to a compiler-generated field
            //CallSite<Func<CallSite, object, string>> p1 = Form1.\u003C\u003Eo__15.\u003C\u003Ep__1;
            //// ISSUE: reference to a compiler-generated field
            //if (Form1.\u003C\u003Eo__15.\u003C\u003Ep__0 == null)
            //{
            //  // ISSUE: reference to a compiler-generated field
            //  Form1.\u003C\u003Eo__15.\u003C\u003Ep__0 = CallSite<Func<CallSite, Encoding, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetString", (IEnumerable<Type>) null, typeof (Form1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            //  {
            //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
            //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            //  }));
            //}
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            //object obj1 = Form1.\u003C\u003Eo__15.\u003C\u003Ep__0.Target((CallSite) Form1.\u003C\u003Eo__15.\u003C\u003Ep__0, Encoding.UTF8, this.WinHT.ResponseBody);
            string text = target((CallSite) null, this.WinHT.ResponseBody);
            try
            {
                this.enterY.Text = text.Split(new string[1]
                {
                    "\"enter_year\":\""
                }, StringSplitOptions.None)[1].Split(new string[1]
                {
                    "\""
                }, StringSplitOptions.None)[0];
                this.studentnumber.Text = text.Split(new string[1]
                {
                    "\"student_no\":\""
                }, StringSplitOptions.None)[1].Split(new string[1]
                {
                    "\""
                }, StringSplitOptions.None)[0];
                this.name.Text = text.Split(new string[1]
                {
                    "\"nm\":\""
                }, StringSplitOptions.None)[1].Split(new string[1]
                {
                    "\""
                }, StringSplitOptions.None)[0];
                if (text.Split(new string[1] {"\"maj_nm\":\""}, StringSplitOptions.None)[1].Split(new string[1]
                {
                    "\""
                }, StringSplitOptions.None)[0] == "")
                    this.majnm.Text = text.Split(new string[1]
                    {
                        "\"cls_nm\":\""
                    }, StringSplitOptions.None)[1].Split(new string[1]
                    {
                        "\""
                    }, StringSplitOptions.None)[0];
                else
                    this.majnm.Text = text.Split(new string[1]
                    {
                        "\"maj_nm\":\""
                    }, StringSplitOptions.None)[1].Split(new string[1]
                    {
                        "\""
                    }, StringSplitOptions.None)[0];
            }
            catch (IndexOutOfRangeException ex)
            {
                int num = (int) MessageBox.Show("차세대 정보 가져오는중 에러발생!\n에러 내용이 자동으로 복사되었습니다.\n개인정보가 들어있으니 지우고 보내주세요.",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Clipboard.SetText(text);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", (Exception) ex);
            }

            // ISSUE: reference to a compiler-generated method
            this.WinHT.Open("Post", "https://nis.gnu.ac.kr/hjjl/hj/sa_hj_1050q.gnu?mode=doListSugang&dept_group_gb=",
                (object) true);
            // ISSUE: reference to a compiler-generated method
            this.WinHT.Send((object) "https://nis.gnu.ac.kr/hjjl/hj/sa_hj_1050q.gnu?mode=doListSugang&dept_group_gb=");
            // ISSUE: reference to a compiler-generated method
            this.WinHT.WaitForResponse(Type.Missing);
            // ISSUE: reference to a compiler-generated field
            //if (Form1.\u003C\u003Eo__15.\u003C\u003Ep__3 == null)
            //{
            //  // ISSUE: reference to a compiler-generated field
            //  Form1.\u003C\u003Eo__15.\u003C\u003Ep__3 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), typeof (Form1)));
            //}
            //// ISSUE: reference to a compiler-generated field
            //Func<CallSite, object, string> target2 = Form1.\u003C\u003Eo__15.\u003C\u003Ep__3.Target;
            //// ISSUE: reference to a compiler-generated field
            //CallSite<Func<CallSite, object, string>> p3 = Form1.\u003C\u003Eo__15.\u003C\u003Ep__3;
            //// ISSUE: reference to a compiler-generated field
            //if (Form1.\u003C\u003Eo__15.\u003C\u003Ep__2 == null)
            //{
            //  // ISSUE: reference to a compiler-generated field
            //  Form1.\u003C\u003Eo__15.\u003C\u003Ep__2 = CallSite<Func<CallSite, Encoding, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetString", (IEnumerable<Type>) null, typeof (Form1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
            //  {
            //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
            //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
            //  }));
            //}
            //// ISSUE: reference to a compiler-generated field
            //// ISSUE: reference to a compiler-generated field
            //object obj2 = Form1.\u003C\u003Eo__15.\u003C\u003Ep__2.Target((CallSite) Form1.\u003C\u003Eo__15.\u003C\u003Ep__2, Encoding.UTF8, this.WinHT.ResponseBody);
            string str1 = target((CallSite) null, this.WinHT.ResponseBody);
            int count = new Regex("rownum").Matches(str1, 0).Count;
            int num1 = int.Parse(count.ToString());
            try
            {
                this.findmajor();
            }
            catch (IndexOutOfRangeException ex)
            {
                int num2 = (int) MessageBox.Show("데이터파일 읽는중 에러 발생!\n에러 내용이 자동으로 복사되었습니다.", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Clipboard.SetText("입학년도 : " + this.enterY.Text + " / 학과 : " + this.majnm.Text);
                throw new ArgumentOutOfRangeException("index parameter is out of range.", (Exception) ex);
            }

            for (int index1 = 0; index1 < num1; ++index1)
            {
                try
                {
                    string str2 = str1.Split(new string[1]
                    {
                        "est_term_gb\":\""
                    }, StringSplitOptions.None)[index1 + 1].Split(new string[1]
                    {
                        "\""
                    }, StringSplitOptions.None)[0];
                    string str3 = str1.Split(new string[1]
                    {
                        "est_year\":\""
                    }, StringSplitOptions.None)[index1 + 1].Split(new string[1]
                    {
                        "\""
                    }, StringSplitOptions.None)[0];
                    // ISSUE: reference to a compiler-generated method
                    this.WinHT.Open("Post",
                        "https://nis.gnu.ac.kr/hjjl/hj/sa_hj_1050q.gnu?mode=doListDtlSugang&dept_group_gb=&est_year=" +
                        str3 + "&est_term_gb=" + str2, (object) true);
                    // ISSUE: reference to a compiler-generated method
                    this.WinHT.Send(
                        (object) (
                            "https://nis.gnu.ac.kr/hjjl/hj/sa_hj_1050q.gnu?mode=doListDtlSugang&dept_group_gb=&est_year=" +
                            str3 + "&est_term_gb=" + str2));
                    // ISSUE: reference to a compiler-generated method
                    this.WinHT.WaitForResponse(Type.Missing);
                    // ISSUE: reference to a compiler-generated field
                    //if (Form1.\u003C\u003Eo__15.\u003C\u003Ep__5 == null)
                    //{
                    //  // ISSUE: reference to a compiler-generated field
                    //  Form1.\u003C\u003Eo__15.\u003C\u003Ep__5 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, typeof (string), typeof (Form1)));
                    //}
                    //// ISSUE: reference to a compiler-generated field
                    //Func<CallSite, object, string> target3 = Form1.\u003C\u003Eo__15.\u003C\u003Ep__5.Target;
                    //// ISSUE: reference to a compiler-generated field
                    //CallSite<Func<CallSite, object, string>> p5 = Form1.\u003C\u003Eo__15.\u003C\u003Ep__5;
                    //// ISSUE: reference to a compiler-generated field
                    //if (Form1.\u003C\u003Eo__15.\u003C\u003Ep__4 == null)
                    //{
                    //  // ISSUE: reference to a compiler-generated field
                    //  Form1.\u003C\u003Eo__15.\u003C\u003Ep__4 = CallSite<Func<CallSite, Encoding, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, "GetString", (IEnumerable<Type>) null, typeof (Form1), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
                    //  {
                    //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null),
                    //    CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null)
                    //  }));
                    //}
                    //// ISSUE: reference to a compiler-generated field
                    //// ISSUE: reference to a compiler-generated field
                    //object obj3 = Form1.\u003C\u003Eo__15.\u003C\u003Ep__4.Target((CallSite) Form1.\u003C\u003Eo__15.\u003C\u003Ep__4, Encoding.UTF8, this.WinHT.ResponseBody);
                    string str4 = target((CallSite) null, this.WinHT.ResponseBody);
                    count = new Regex("rownum").Matches(str4, 0).Count;
                    int num2 = int.Parse(count.ToString());
                    for (int index2 = 0; index2 < num2; ++index2)
                    {
                        try
                        {
                            string str2_1 = str4.Split(new string[1]
                            {
                                "credit\":\""
                            }, StringSplitOptions.None)[index2 + 1].Split(new string[1]
                            {
                                "\""
                            }, StringSplitOptions.None)[0];
                            string str5 = str4.Split(new string[1]
                            {
                                "est_year_term\":\""
                            }, StringSplitOptions.None)[index2 + 1].Split(new string[1]
                            {
                                "\""
                            }, StringSplitOptions.None)[0];
                            string str6 = str4.Split(new string[1]
                            {
                                "isu_nm\":\""
                            }, StringSplitOptions.None)[index2 + 1].Split(new string[1]
                            {
                                "\""
                            }, StringSplitOptions.None)[0];
                            string str7 = str4.Split(new string[1]
                            {
                                "subject_nm\":\""
                            }, StringSplitOptions.None)[index2 + 1].Split(new string[1]
                            {
                                "\""
                            }, StringSplitOptions.None)[0];
                            this.findfunda(str7, str2_1);
                            this.listView1.Items.Add(new ListViewItem()
                            {
                                Text = str2_1,
                                SubItems =
                                {
                                    str5,
                                    str6,
                                    str7
                                }
                            });
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            int num3 = (int) MessageBox.Show("이수과목 정보 받는중 에러발생!\n에러 내용이 자동으로 복사되었습니다.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            Clipboard.SetText(str4);
                            throw new ArgumentOutOfRangeException("index parameter is out of range.", (Exception) ex);
                        }
                    }
                }
                catch (IndexOutOfRangeException ex)
                {
                    int num2 = (int) MessageBox.Show("이수학기 정보 받는중 에러 발생!\n에러 내용이 자동으로 복사되었습니다.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Clipboard.SetText(str1);
                    throw new ArgumentOutOfRangeException("index parameter is out of range.", (Exception) ex);
                }
            }

            this.label18.Text = Convert.ToString(this.sumsum1);
            this.listView1.CheckBoxes = true;
            for (int startIndex1 = 0; startIndex1 < this.listView1.Items.Count; ++startIndex1)
            {
                for (int startIndex2 = 0; startIndex2 < this.listView14.Items.Count; ++startIndex2)
                {
                    ListViewItem itemWithText1 = this.listView1.FindItemWithText("전공필수", true, startIndex1, false);
                    if (itemWithText1 != null)
                    {
                        ListViewItem itemWithText2 = this.listView14.FindItemWithText(itemWithText1.SubItems[3].Text,
                            true, startIndex2, false);
                        if (itemWithText2 != null)
                        {
                            itemWithText2.BackColor = Color.Aquamarine;
                            itemWithText1.ForeColor = Color.Red;
                            itemWithText1.Checked = true;
                            break;
                        }

                        break;
                    }
                }
            }

            ListView.CheckedListViewItemCollection checkedItems = this.listView1.CheckedItems;
            foreach (ListViewItem listViewItem in checkedItems)
                this.majsum1 += double.Parse(listViewItem.Text);
            this.label15.Text = Convert.ToString(this.majsum1);
            for (int index = 0; index < this.listView1.Items.Count; ++index)
                this.listView1.Items[index].Checked = false;
            for (int startIndex1 = 0; startIndex1 < this.listView1.Items.Count; ++startIndex1)
            {
                int startIndex2 = 0;
                if (startIndex2 < this.listView14.Items.Count)
                {
                    ListViewItem itemWithText1 = this.listView1.FindItemWithText("전공선택", true, startIndex1, false);
                    if (itemWithText1 != null)
                    {
                        ListViewItem itemWithText2 = this.listView14.FindItemWithText(itemWithText1.SubItems[3].Text,
                            true, startIndex2, false);
                        if (itemWithText2 != null)
                        {
                            itemWithText2.BackColor = Color.Aquamarine;
                            itemWithText1.ForeColor = Color.Red;
                            itemWithText1.Checked = true;
                        }
                    }

                    ListViewItem itemWithText3 = this.listView1.FindItemWithText("일반선택", true, startIndex1, false);
                    if (itemWithText3 != null)
                    {
                        ListViewItem itemWithText2 = this.listView14.FindItemWithText(itemWithText3.SubItems[3].Text,
                            true, startIndex2, false);
                        if (itemWithText2 != null)
                        {
                            itemWithText2.BackColor = Color.Aquamarine;
                            itemWithText3.ForeColor = Color.Red;
                            itemWithText3.Checked = true;
                        }
                    }
                }
            }

            foreach (ListViewItem listViewItem in checkedItems)
                this.majsum2 += double.Parse(listViewItem.Text);
            this.label16.Text = Convert.ToString(this.majsum2);
            this.listView1.CheckBoxes = false;
            for (int index1 = 0; index1 < this.listView1.Items.Count; ++index1)
            {
                for (int index2 = 0; index2 < this.listView1.Items.Count; ++index2)
                {
                    if (index1 != index2 && this.listView1.Items[index2].SubItems[3].Text != "꿈·미래개척" &&
                        this.listView1.Items[index1].SubItems[3].Text == this.listView1.Items[index2].SubItems[3].Text)
                        this.listView1.Items[index2].Remove();
                }

                this.sumsum1 += double.Parse(this.listView1.Items[index1].Text);
            }

            this.label17.Text = Convert.ToString(double.Parse(this.label16.Text) + double.Parse(this.label15.Text));
            this.label10.Text = Convert.ToString(this.unida1 + this.unida2);
            for (int index = 0; index < 7; ++index)
            {
                if (this.fundasum[index] > 2)
                    this.fundasum[index] = 2;
                this.fundasusum += this.fundasum[index];
            }

            this.label11.Text = Convert.ToString(this.fundasusum);
            this.label14.Text = Convert.ToString(int.Parse(this.label10.Text) + int.Parse(this.label11.Text) +
                                                 int.Parse(this.label13.Text));
            this.label18.Text = Convert.ToString(this.sumsum1);
        }

        private void findmajor()
        {
            string str1 = Form1.Base64String.Base64Decoding(File.ReadAllText("data.dat"));
            string str2 = str1.Split(new string[1]
            {
                this.enterY.Text
            }, StringSplitOptions.None)[1].Split(new string[1]
            {
                "|END"
            }, StringSplitOptions.None)[0].Split(new string[1]
            {
                this.majnm.Text + "|"
            }, StringSplitOptions.None)[1].Split(new string[1]
            {
                "C"
            }, StringSplitOptions.None)[0];
            this.label1.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[1].Split(new string[1]
            {
                "|"
            }, StringSplitOptions.None)[0];
            this.label2.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[2].Split(new string[1]
            {
                "|"
            }, StringSplitOptions.None)[0];
            this.label4.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[3].Split(new string[1]
            {
                "|"
            }, StringSplitOptions.None)[0];
            this.label5.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[4].Split(new string[1]
            {
                "|"
            }, StringSplitOptions.None)[0];
            this.label9.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[10].Split(new string[1]
            {
                "|"
            }, StringSplitOptions.None)[0];
            if (int.Parse(this.enterY.Text) > 2016)
            {
                if (str2.Split(new string[1] {"|"}, StringSplitOptions.None)[12].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0] == "D")
                {
                    this.label6.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[13].Split(new string[1]
                    {
                        "|"
                    }, StringSplitOptions.None)[0];
                    this.label7.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[14].Split(new string[1]
                    {
                        "|"
                    }, StringSplitOptions.None)[0];
                    this.label8.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[15].Split(new string[1]
                    {
                        "|"
                    }, StringSplitOptions.None)[0];
                }
                else
                {
                    this.label6.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[5].Split(new string[1]
                    {
                        "|"
                    }, StringSplitOptions.None)[0];
                    this.label7.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[15].Split(new string[1]
                    {
                        "|"
                    }, StringSplitOptions.None)[0];
                    this.label8.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[16].Split(new string[1]
                    {
                        "|"
                    }, StringSplitOptions.None)[0];
                }
            }
            else if (str2.Split(new string[1] {"|"}, StringSplitOptions.None)[14] == "")
            {
                this.label6.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[5].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.label7.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[12].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.label8.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[13].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
            }
            else
            {
                this.label6.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[12].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.label7.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[13].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.label8.Text = str2.Split(new string[1] {"|"}, StringSplitOptions.None)[14].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
            }

            int count;
            if (this.label4.Text == "0")
            {
                this.listView9.Items.Add(new ListViewItem()
                {
                    Text = "기초교양 없음"
                });
            }
            else
            {
                string input = str1.Split(new string[1] {"기초교양"}, StringSplitOptions.None)[1].Split(new string[1]
                {
                    "|END"
                }, StringSplitOptions.None)[0].Split(new string[1]
                {
                    this.majnm.Text
                }, StringSplitOptions.None)[1].Split(new string[1]
                {
                    "|FC"
                }, StringSplitOptions.None)[0];
                count = new Regex("F").Matches(input, 0).Count;
                int num = int.Parse(count.ToString());
                for (int index = 1; index < (num + 1) / 2; ++index)
                {
                    string str3 = input.Split(new string[1] {"|F"}, StringSplitOptions.None)[2 * index].Split(
                        new string[1]
                        {
                            "|F"
                        }, StringSplitOptions.None)[0];
                    string str4 = input.Split(new string[1] {"|F"}, StringSplitOptions.None)[2 * index + 1].Split(
                        new string[1]
                        {
                            "|F"
                        }, StringSplitOptions.None)[0];
                    this.listView9.Items.Add(new ListViewItem()
                    {
                        Text = str3,
                        SubItems =
                        {
                            str4
                        }
                    });
                }
            }

            string input1 = str1.Split(new string[1] {"전공과목|"}, StringSplitOptions.None)[1].Split(new string[1]
            {
                "|END"
            }, StringSplitOptions.None)[0].Split(new string[1]
            {
                this.majnm.Text
            }, StringSplitOptions.None)[1].Split(new string[1]
            {
                "|EXIT"
            }, StringSplitOptions.None)[0];
            count = new Regex("F").Matches(input1, 0).Count;
            int num1 = int.Parse(count.ToString());
            for (int index = 0; index < (num1 + 2) / 4; ++index)
            {
                string str3 = input1.Split(new string[1] {"|F"}, StringSplitOptions.None)[4 * index + 1].Split(
                    new string[1]
                    {
                        "|F"
                    }, StringSplitOptions.None)[0];
                string str4 = input1.Split(new string[1] {"|F"}, StringSplitOptions.None)[4 * index + 3].Split(
                    new string[1]
                    {
                        "|F"
                    }, StringSplitOptions.None)[0];
                string str5 = input1.Split(new string[1] {"|F"}, StringSplitOptions.None)[4 * index + 4].Split(
                    new string[1]
                    {
                        "|F"
                    }, StringSplitOptions.None)[0];
                string str6 = input1.Split(new string[1] {"|F"}, StringSplitOptions.None)[4 * index + 2].Split(
                    new string[1]
                    {
                        "|F"
                    }, StringSplitOptions.None)[0];
                this.listView14.Items.Add(new ListViewItem()
                {
                    Text = str3,
                    SubItems =
                    {
                        str4,
                        str5,
                        str6
                    }
                });
            }

            string str7 = str1.Split(new string[1] {"자연영역|"}, StringSplitOptions.None)[1].Split(new string[1]
            {
                "|END"
            }, StringSplitOptions.None)[0];
            string str8 = str1.Split(new string[1] {"인문사회|"}, StringSplitOptions.None)[1].Split(new string[1]
            {
                "|END"
            }, StringSplitOptions.None)[0];
            string str9 = str1.Split(new string[1] {"외국어|"}, StringSplitOptions.None)[1].Split(new string[1]
            {
                "|END"
            }, StringSplitOptions.None)[0];
            string input2 = str7;
            string input3 = str8;
            string input4 = str9;
            count = new Regex("F").Matches(input2, 0).Count;
            int num2 = int.Parse(count.ToString());
            count = new Regex("F").Matches(input3, 0).Count;
            int num3 = int.Parse(count.ToString());
            count = new Regex("F").Matches(input4, 0).Count;
            int num4 = int.Parse(count.ToString());
            for (int index = 0; index < num2; ++index)
            {
                string str3 = str7.Split(new string[1] {"|F"}, StringSplitOptions.None)[index + 1].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.listView11.Items.Add(new ListViewItem()
                {
                    Text = str3
                });
            }

            for (int index = 0; index < num3; ++index)
            {
                string str3 = str8.Split(new string[1] {"|F"}, StringSplitOptions.None)[index + 1].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.listView12.Items.Add(new ListViewItem()
                {
                    Text = str3
                });
            }

            for (int index = 0; index < num4; ++index)
            {
                string str3 = input4.Split(new string[1] {"|F"}, StringSplitOptions.None)[index + 1].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.listView13.Items.Add(new ListViewItem()
                {
                    Text = str3
                });
            }

            string str10 = str1.Split(new string[1] {"핵심교양"}, StringSplitOptions.None)[1].Split(new string[1]
            {
                "|END"
            }, StringSplitOptions.None)[0];
            string input5 = str10;
            count = new Regex("문학과문화").Matches(input5, 0).Count;
            int num5 = int.Parse(count.ToString());
            for (int index = 0; index < num5; ++index)
            {
                string str3 = str10.Split(new string[1]
                {
                    "\x2460문학과문화|"
                }, StringSplitOptions.None)[index + 1].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.listView2.Items.Add(new ListViewItem()
                {
                    Text = str3
                });
            }

            count = new Regex("역사와철학").Matches(input5, 0).Count;
            int num6 = int.Parse(count.ToString());
            for (int index = 0; index < num6; ++index)
            {
                string str3 = str10.Split(new string[1]
                {
                    "\x2461역사와철학|"
                }, StringSplitOptions.None)[index + 1].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.listView3.Items.Add(new ListViewItem()
                {
                    Text = str3
                });
            }

            count = new Regex("인간과사회").Matches(input5, 0).Count;
            int num7 = int.Parse(count.ToString());
            for (int index = 0; index < num7; ++index)
            {
                string str3 = str10.Split(new string[1]
                {
                    "\x2462인간과사회|"
                }, StringSplitOptions.None)[index + 1].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.listView4.Items.Add(new ListViewItem()
                {
                    Text = str3
                });
            }

            count = new Regex("생명과환경").Matches(input5, 0).Count;
            int num8 = int.Parse(count.ToString());
            for (int index = 0; index < num8; ++index)
            {
                string str3 = str10.Split(new string[1]
                {
                    "\x2463생명과환경|"
                }, StringSplitOptions.None)[index + 1].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.listView5.Items.Add(new ListViewItem()
                {
                    Text = str3
                });
            }

            count = new Regex("과학과기술").Matches(input5, 0).Count;
            int num9 = int.Parse(count.ToString());
            for (int index = 0; index < num9; ++index)
            {
                string str3 = str10.Split(new string[1]
                {
                    "\x2464과학과기술|"
                }, StringSplitOptions.None)[index + 1].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.listView6.Items.Add(new ListViewItem()
                {
                    Text = str3
                });
            }

            count = new Regex("예술과체육").Matches(input5, 0).Count;
            int num10 = int.Parse(count.ToString());
            for (int index = 0; index < num10; ++index)
            {
                string str3 = str10.Split(new string[1]
                {
                    "\x2465예술과체육|"
                }, StringSplitOptions.None)[index + 1].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.listView7.Items.Add(new ListViewItem()
                {
                    Text = str3
                });
            }

            count = new Regex("융·복합 영역").Matches(input5, 0).Count;
            int num11 = int.Parse(count.ToString());
            for (int index = 0; index < num11; ++index)
            {
                string str3 = str10.Split(new string[1]
                {
                    "\x2466융·복합 영역|"
                }, StringSplitOptions.None)[index + 1].Split(new string[1]
                {
                    "|"
                }, StringSplitOptions.None)[0];
                this.listView8.Items.Add(new ListViewItem()
                {
                    Text = str3
                });
            }
        }

        private void findfunda(string str, string str2)
        {
            for (int startIndex1 = 0; startIndex1 < this.listView9.Items.Count; ++startIndex1)
            {
                ListViewItem itemWithText1 = this.listView9.FindItemWithText(str, false, startIndex1, true);
                ListViewItem itemWithText2 = this.listView9.FindItemWithText("자연영역", false, startIndex1, true);
                ListViewItem itemWithText3 = this.listView9.FindItemWithText("인문사회", false, startIndex1, true);
                ListViewItem itemWithText4 = this.listView9.FindItemWithText("외국어", false, startIndex1, true);
                if (itemWithText1 != null)
                {
                    itemWithText1.BackColor = Color.Aquamarine;
                    this.bassum += int.Parse(str2);
                    this.label13.Text = Convert.ToString(this.bassum);
                    break;
                }

                for (int startIndex2 = 0; startIndex2 < this.listView11.Items.Count; ++startIndex2)
                {
                    ListViewItem itemWithText5 = this.listView11.FindItemWithText(str, false, startIndex2, true);
                    if (itemWithText2 != null && itemWithText5 != null)
                    {
                        itemWithText2.BackColor = Color.Aquamarine;
                        itemWithText5.BackColor = Color.Aquamarine;
                        itemWithText2.Text = itemWithText5.Text + " - 자연영역 택";
                    }
                }

                for (int index = 0; index < this.listView12.Items.Count; ++index)
                {
                    ListViewItem itemWithText5 = this.listView12.FindItemWithText(str, false, startIndex1, true);
                    if (itemWithText3 != null && itemWithText5 != null)
                    {
                        itemWithText3.BackColor = Color.Aquamarine;
                        itemWithText5.BackColor = Color.Aquamarine;
                        itemWithText3.Text = itemWithText5.Text + " - 인문사회영역 택";
                    }
                }

                for (int index = 0; index < this.listView13.Items.Count; ++index)
                {
                    ListViewItem itemWithText5 = this.listView13.FindItemWithText(str, false, startIndex1, true);
                    if (itemWithText4 != null && itemWithText5 != null)
                    {
                        itemWithText4.BackColor = Color.Aquamarine;
                        itemWithText5.BackColor = Color.Aquamarine;
                        itemWithText4.Text = itemWithText5.Text + " - 외국어영역 택";
                    }
                }
            }

            for (int startIndex = 0; startIndex < this.listView10.Items.Count; ++startIndex)
            {
                ListViewItem itemWithText = this.listView10.FindItemWithText(str, false, startIndex, true);
                if (itemWithText != null)
                {
                    itemWithText.BackColor = Color.Aquamarine;
                    if (itemWithText.Index < 5)
                    {
                        this.unida1 += int.Parse(str2);
                        this.label30.Text = "필수교과목 : " + Convert.ToString(this.unida1) + " 학점";
                        break;
                    }

                    this.unida2 += int.Parse(str2);
                    this.label31.Text = "선택교과목 : " + Convert.ToString(this.unida2) + " 학점";
                    break;
                }
            }

            for (int startIndex = 0; startIndex < this.listView2.Items.Count; ++startIndex)
            {
                ListViewItem itemWithText = this.listView2.FindItemWithText(str, false, startIndex, true);
                if (itemWithText != null)
                {
                    itemWithText.BackColor = Color.Aquamarine;
                    this.fundasum[0] += 2;
                    this.label19.Text = "\x2460 : " + Convert.ToString(this.fundasum[0]);
                    this.label19.ForeColor = Color.Red;
                    break;
                }
            }

            for (int startIndex = 0; startIndex < this.listView3.Items.Count; ++startIndex)
            {
                ListViewItem itemWithText = this.listView3.FindItemWithText(str, false, startIndex, true);
                if (itemWithText != null)
                {
                    itemWithText.BackColor = Color.Aquamarine;
                    this.fundasum[1] += 2;
                    this.label20.Text = "\x2461 : " + Convert.ToString(this.fundasum[1]);
                    this.label20.ForeColor = Color.Red;
                    break;
                }
            }

            for (int startIndex = 0; startIndex < this.listView4.Items.Count; ++startIndex)
            {
                ListViewItem itemWithText = this.listView4.FindItemWithText(str, false, startIndex, true);
                if (itemWithText != null)
                {
                    itemWithText.BackColor = Color.Aquamarine;
                    this.fundasum[2] += 2;
                    this.label21.Text = "\x2462 : " + Convert.ToString(this.fundasum[2]);
                    this.label21.ForeColor = Color.Red;
                    break;
                }
            }

            for (int startIndex = 0; startIndex < this.listView5.Items.Count; ++startIndex)
            {
                ListViewItem itemWithText = this.listView5.FindItemWithText(str, false, startIndex, true);
                if (itemWithText != null)
                {
                    itemWithText.BackColor = Color.Aquamarine;
                    this.fundasum[3] += 2;
                    this.label22.Text = "\x2463 : " + Convert.ToString(this.fundasum[3]);
                    this.label22.ForeColor = Color.Red;
                    break;
                }
            }

            for (int startIndex = 0; startIndex < this.listView6.Items.Count; ++startIndex)
            {
                ListViewItem itemWithText = this.listView6.FindItemWithText(str, false, startIndex, true);
                if (itemWithText != null)
                {
                    itemWithText.BackColor = Color.Aquamarine;
                    this.fundasum[4] += 2;
                    this.label23.Text = "\x2464 : " + Convert.ToString(this.fundasum[4]);
                    this.label23.ForeColor = Color.Red;
                    break;
                }
            }

            for (int startIndex = 0; startIndex < this.listView7.Items.Count; ++startIndex)
            {
                ListViewItem itemWithText = this.listView7.FindItemWithText(str, false, startIndex, true);
                if (itemWithText != null)
                {
                    itemWithText.BackColor = Color.Aquamarine;
                    this.fundasum[5] += 2;
                    this.label24.Text = "\x2465 : " + Convert.ToString(this.fundasum[5]);
                    this.label24.ForeColor = Color.Red;
                    break;
                }
            }

            for (int startIndex = 0; startIndex < this.listView8.Items.Count; ++startIndex)
            {
                ListViewItem itemWithText = this.listView8.FindItemWithText(str, false, startIndex, true);
                if (itemWithText != null)
                {
                    itemWithText.BackColor = Color.Aquamarine;
                    this.fundasum[6] += 2;
                    this.label25.Text = "\x2466 : " + Convert.ToString(this.fundasum[6]);
                    this.label25.ForeColor = Color.Red;
                    break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                this.listView2.Visible = true;
                this.listView3.Visible = false;
                this.listView4.Visible = false;
                this.listView5.Visible = false;
                this.listView6.Visible = false;
                this.listView7.Visible = false;
                this.listView8.Visible = false;
            }
            else if (this.comboBox1.SelectedIndex == 1)
            {
                this.listView2.Visible = false;
                this.listView3.Visible = true;
                this.listView4.Visible = false;
                this.listView5.Visible = false;
                this.listView6.Visible = false;
                this.listView7.Visible = false;
                this.listView8.Visible = false;
            }
            else if (this.comboBox1.SelectedIndex == 2)
            {
                this.listView2.Visible = false;
                this.listView3.Visible = false;
                this.listView4.Visible = true;
                this.listView5.Visible = false;
                this.listView6.Visible = false;
                this.listView7.Visible = false;
                this.listView8.Visible = false;
            }
            else if (this.comboBox1.SelectedIndex == 3)
            {
                this.listView2.Visible = false;
                this.listView3.Visible = false;
                this.listView4.Visible = false;
                this.listView5.Visible = true;
                this.listView6.Visible = false;
                this.listView7.Visible = false;
                this.listView8.Visible = false;
            }
            else if (this.comboBox1.SelectedIndex == 4)
            {
                this.listView2.Visible = false;
                this.listView3.Visible = false;
                this.listView4.Visible = false;
                this.listView5.Visible = false;
                this.listView6.Visible = true;
                this.listView7.Visible = false;
                this.listView8.Visible = false;
            }
            else if (this.comboBox1.SelectedIndex == 5)
            {
                this.listView2.Visible = false;
                this.listView3.Visible = false;
                this.listView4.Visible = false;
                this.listView5.Visible = false;
                this.listView6.Visible = false;
                this.listView7.Visible = true;
                this.listView8.Visible = false;
            }
            else
            {
                if (this.comboBox1.SelectedIndex != 6)
                    return;
                this.listView2.Visible = false;
                this.listView3.Visible = false;
                this.listView4.Visible = false;
                this.listView5.Visible = false;
                this.listView6.Visible = false;
                this.listView7.Visible = false;
                this.listView8.Visible = true;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ListViewGroup listViewGroup1 = new ListViewGroup("필수교과목", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("선택교과목", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem("대학영어1");
            ListViewItem listViewItem2 = new ListViewItem("대학영어2");
            ListViewItem listViewItem3 = new ListViewItem("글쓰기기초　　　　　┐");
            ListViewItem listViewItem4 = new ListViewItem("자연과학글쓰기　　　├ 맞는 한가지");
            ListViewItem listViewItem5 = new ListViewItem("인문사회과학글쓰기　┘  과목만 이수");
            ListViewItem listViewItem6 = new ListViewItem("비판적사고");
            ListViewItem listViewItem7 = new ListViewItem("수리통계적사고");
            ListViewItem listViewItem8 = new ListViewItem("GNU인성");
            ListViewItem listViewItem9 = new ListViewItem("글쓰기심화");
            ListViewItem listViewItem10 = new ListViewItem("발표와토론");
            ListViewItem listViewItem11 = new ListViewItem("컴퓨팅사고와코딩");
            ListViewItem listViewItem12 = new ListViewItem("영어읽기와토론");
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
            this.button1 = new Button();
            this.ID = new TextBox();
            this.PW = new TextBox();
            this.studentnumber = new Label();
            this.majnm = new Label();
            this.maj2nm = new Label();
            this.name = new Label();
            this.enterY = new Label();
            this.columnHeader1 = new ColumnHeader();
            this.columnHeader2 = new ColumnHeader();
            this.listView1 = new ListView();
            this.columnHeader3 = new ColumnHeader();
            this.columnHeader4 = new ColumnHeader();
            this.columnHeader5 = new ColumnHeader();
            this.columnHeader6 = new ColumnHeader();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label4 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            this.label8 = new Label();
            this.label9 = new Label();
            this.label10 = new Label();
            this.label11 = new Label();
            this.label13 = new Label();
            this.label14 = new Label();
            this.label15 = new Label();
            this.label16 = new Label();
            this.label17 = new Label();
            this.label18 = new Label();
            this.listView2 = new ListView();
            this.columnHeader7 = new ColumnHeader();
            this.comboBox1 = new ComboBox();
            this.listView3 = new ListView();
            this.columnHeader8 = new ColumnHeader();
            this.listView4 = new ListView();
            this.columnHeader9 = new ColumnHeader();
            this.listView5 = new ListView();
            this.columnHeader10 = new ColumnHeader();
            this.listView6 = new ListView();
            this.columnHeader11 = new ColumnHeader();
            this.listView7 = new ListView();
            this.columnHeader12 = new ColumnHeader();
            this.listView8 = new ListView();
            this.columnHeader13 = new ColumnHeader();
            this.label19 = new Label();
            this.label20 = new Label();
            this.label21 = new Label();
            this.label22 = new Label();
            this.label23 = new Label();
            this.label24 = new Label();
            this.label25 = new Label();
            this.label26 = new Label();
            this.label27 = new Label();
            this.label28 = new Label();
            this.label29 = new Label();
            this.listView9 = new ListView();
            this.columnHeader16 = new ColumnHeader();
            this.columnHeader14 = new ColumnHeader();
            this.listView10 = new ListView();
            this.columnHeader15 = new ColumnHeader();
            this.label30 = new Label();
            this.label31 = new Label();
            this.listView11 = new ListView();
            this.columnHeader21 = new ColumnHeader();
            this.listView12 = new ListView();
            this.columnHeader22 = new ColumnHeader();
            this.listView13 = new ListView();
            this.columnHeader23 = new ColumnHeader();
            this.listView14 = new ListView();
            this.columnHeader17 = new ColumnHeader();
            this.columnHeader18 = new ColumnHeader();
            this.columnHeader19 = new ColumnHeader();
            this.columnHeader20 = new ColumnHeader();
            this.label32 = new Label();
            this.pictureBox1 = new PictureBox();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            this.SuspendLayout();
            this.button1.Location = new Point((int) byte.MaxValue, 11);
            this.button1.Margin = new Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new Size(119, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "로그인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.ID.Location = new Point(13, 14);
            this.ID.Margin = new Padding(3, 2, 3, 2);
            this.ID.Name = "ID";
            this.ID.Size = new Size(241, 25);
            this.ID.TabIndex = 1;
            this.ID.Text = "차세대 ID";
            this.ID.Click += new EventHandler(this.ID_Click);
            this.PW.Cursor = Cursors.IBeam;
            this.PW.Location = new Point(13, 41);
            this.PW.Margin = new Padding(3, 2, 3, 2);
            this.PW.Name = "PW";
            this.PW.PasswordChar = '●';
            this.PW.Size = new Size(241, 25);
            this.PW.TabIndex = 2;
            this.PW.Click += new EventHandler(this.PW_Click);
            this.studentnumber.BackColor = Color.White;
            this.studentnumber.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.studentnumber.Location = new Point(85, 19);
            this.studentnumber.Name = "studentnumber";
            this.studentnumber.Size = new Size(131, 21);
            this.studentnumber.TabIndex = 3;
            this.studentnumber.Text = "student_nm";
            this.studentnumber.TextAlign = ContentAlignment.MiddleCenter;
            this.studentnumber.Visible = false;
            this.majnm.BackColor = Color.White;
            this.majnm.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.majnm.Location = new Point(85, 45);
            this.majnm.Name = "majnm";
            this.majnm.Size = new Size(275, 21);
            this.majnm.TabIndex = 4;
            this.majnm.Text = "major_nm";
            this.majnm.TextAlign = ContentAlignment.MiddleCenter;
            this.majnm.Visible = false;
            this.maj2nm.BackColor = Color.White;
            this.maj2nm.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.maj2nm.Location = new Point(440, 45);
            this.maj2nm.Name = "maj2nm";
            this.maj2nm.Size = new Size(201, 21);
            this.maj2nm.TabIndex = 5;
            this.maj2nm.Text = "maj2_nm";
            this.maj2nm.TextAlign = ContentAlignment.MiddleCenter;
            this.maj2nm.Visible = false;
            this.name.BackColor = Color.White;
            this.name.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.name.Location = new Point(299, 19);
            this.name.Name = "name";
            this.name.Size = new Size(59, 21);
            this.name.TabIndex = 7;
            this.name.Text = "name";
            this.name.TextAlign = ContentAlignment.MiddleCenter;
            this.name.Visible = false;
            this.enterY.BackColor = Color.White;
            this.enterY.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.enterY.Location = new Point(440, 19);
            this.enterY.Name = "enterY";
            this.enterY.Size = new Size(59, 21);
            this.enterY.TabIndex = 8;
            this.enterY.Text = "enterY";
            this.enterY.TextAlign = ContentAlignment.MiddleCenter;
            this.enterY.Visible = false;
            this.listView1.Columns.AddRange(new ColumnHeader[4]
            {
                this.columnHeader3,
                this.columnHeader4,
                this.columnHeader5,
                this.columnHeader6
            });
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new Point(672, 42);
            this.listView1.Margin = new Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new Size(364, 302);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = View.Details;
            this.columnHeader3.Text = "학점";
            this.columnHeader3.Width = 40;
            this.columnHeader4.Text = "이수학기";
            this.columnHeader4.Width = 73;
            this.columnHeader5.Text = "이수과정";
            this.columnHeader6.Text = "과목명";
            this.columnHeader6.Width = 188;
            this.label1.BackColor = Color.White;
            this.label1.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label1.Location = new Point(91, 134);
            this.label1.Name = "label1";
            this.label1.Size = new Size(51, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "0";
            this.label1.TextAlign = ContentAlignment.MiddleCenter;
            this.label2.BackColor = Color.White;
            this.label2.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label2.Location = new Point(165, 134);
            this.label2.Name = "label2";
            this.label2.Size = new Size(51, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "0";
            this.label2.TextAlign = ContentAlignment.MiddleCenter;
            this.label4.BackColor = Color.White;
            this.label4.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label4.Location = new Point(235, 134);
            this.label4.Name = "label4";
            this.label4.Size = new Size(51, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "0";
            this.label4.TextAlign = ContentAlignment.MiddleCenter;
            this.label5.BackColor = Color.White;
            this.label5.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label5.Location = new Point(305, 134);
            this.label5.Name = "label5";
            this.label5.Size = new Size(51, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "0";
            this.label5.TextAlign = ContentAlignment.MiddleCenter;
            this.label6.BackColor = Color.White;
            this.label6.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label6.Location = new Point(376, 134);
            this.label6.Name = "label6";
            this.label6.Size = new Size(51, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "0";
            this.label6.TextAlign = ContentAlignment.MiddleCenter;
            this.label7.BackColor = Color.White;
            this.label7.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label7.Location = new Point(447, 134);
            this.label7.Name = "label7";
            this.label7.Size = new Size(51, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "0";
            this.label7.TextAlign = ContentAlignment.MiddleCenter;
            this.label8.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label8.Location = new Point(518, 134);
            this.label8.Name = "label8";
            this.label8.Size = new Size(51, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "0";
            this.label8.TextAlign = ContentAlignment.MiddleCenter;
            this.label9.BackColor = Color.White;
            this.label9.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label9.Location = new Point(590, 134);
            this.label9.Name = "label9";
            this.label9.Size = new Size(51, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "0";
            this.label9.TextAlign = ContentAlignment.MiddleCenter;
            this.label10.BackColor = Color.White;
            this.label10.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label10.Location = new Point(91, 184);
            this.label10.Name = "label10";
            this.label10.Size = new Size(51, 19);
            this.label10.TabIndex = 20;
            this.label10.Text = "0";
            this.label10.TextAlign = ContentAlignment.MiddleCenter;
            this.label11.BackColor = Color.White;
            this.label11.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label11.Location = new Point(165, 184);
            this.label11.Name = "label11";
            this.label11.Size = new Size(51, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "0";
            this.label11.TextAlign = ContentAlignment.MiddleCenter;
            this.label13.BackColor = Color.White;
            this.label13.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label13.Location = new Point(235, 184);
            this.label13.Name = "label13";
            this.label13.Size = new Size(51, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "0";
            this.label13.TextAlign = ContentAlignment.MiddleCenter;
            this.label14.BackColor = Color.White;
            this.label14.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label14.Location = new Point(305, 184);
            this.label14.Name = "label14";
            this.label14.Size = new Size(51, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "0";
            this.label14.TextAlign = ContentAlignment.MiddleCenter;
            this.label15.BackColor = Color.White;
            this.label15.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label15.Location = new Point(376, 184);
            this.label15.Name = "label15";
            this.label15.Size = new Size(51, 19);
            this.label15.TabIndex = 25;
            this.label15.Text = "0";
            this.label15.TextAlign = ContentAlignment.MiddleCenter;
            this.label16.BackColor = Color.White;
            this.label16.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label16.Location = new Point(447, 184);
            this.label16.Name = "label16";
            this.label16.Size = new Size(51, 19);
            this.label16.TabIndex = 26;
            this.label16.Text = "0";
            this.label16.TextAlign = ContentAlignment.MiddleCenter;
            this.label17.BackColor = Color.White;
            this.label17.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label17.Location = new Point(518, 184);
            this.label17.Name = "label17";
            this.label17.Size = new Size(51, 19);
            this.label17.TabIndex = 27;
            this.label17.Text = "0";
            this.label17.TextAlign = ContentAlignment.MiddleCenter;
            this.label18.BackColor = Color.White;
            this.label18.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.label18.Location = new Point(590, 184);
            this.label18.Name = "label18";
            this.label18.Size = new Size(51, 19);
            this.label18.TabIndex = 28;
            this.label18.Text = "0";
            this.label18.TextAlign = ContentAlignment.MiddleCenter;
            this.listView2.Columns.AddRange(new ColumnHeader[1]
            {
                this.columnHeader7
            });
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new Point(9, 262);
            this.listView2.Margin = new Padding(3, 4, 3, 4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new Size(326, 420);
            this.listView2.TabIndex = 30;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = View.Details;
            this.columnHeader7.Text = "\x2460문학과문화";
            this.columnHeader7.Width = 240;
            this.comboBox1.Cursor = Cursors.Default;
            this.comboBox1.Font = new Font("맑은 고딕", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[7]
            {
                (object) "\x2460문학과문화",
                (object) "\x2461역사와철학",
                (object) "\x2462인간과사회",
                (object) "\x2463생명과환경",
                (object) "\x2464과학과기술",
                (object) "\x2465예술과체육",
                (object) "\x2466융·복합 영역"
            });
            this.comboBox1.Location = new Point(10, 262);
            this.comboBox1.Margin = new Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(325, 29);
            this.comboBox1.TabIndex = 31;
            this.comboBox1.Text = "\x2460문학과문화";
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            this.listView3.Columns.AddRange(new ColumnHeader[1]
            {
                this.columnHeader8
            });
            this.listView3.FullRowSelect = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new Point(10, 262);
            this.listView3.Margin = new Padding(3, 4, 3, 4);
            this.listView3.Name = "listView3";
            this.listView3.Size = new Size(326, 420);
            this.listView3.TabIndex = 32;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = View.Details;
            this.columnHeader8.Text = "\x2461역사와철학";
            this.columnHeader8.Width = 240;
            this.listView4.Columns.AddRange(new ColumnHeader[1]
            {
                this.columnHeader9
            });
            this.listView4.FullRowSelect = true;
            this.listView4.HideSelection = false;
            this.listView4.Location = new Point(10, 262);
            this.listView4.Margin = new Padding(3, 4, 3, 4);
            this.listView4.Name = "listView4";
            this.listView4.Size = new Size(326, 420);
            this.listView4.TabIndex = 33;
            this.listView4.UseCompatibleStateImageBehavior = false;
            this.listView4.View = View.Details;
            this.columnHeader9.Text = "\x2462인간과사회";
            this.columnHeader9.Width = 240;
            this.listView5.Columns.AddRange(new ColumnHeader[1]
            {
                this.columnHeader10
            });
            this.listView5.FullRowSelect = true;
            this.listView5.HideSelection = false;
            this.listView5.Location = new Point(10, 262);
            this.listView5.Margin = new Padding(3, 4, 3, 4);
            this.listView5.Name = "listView5";
            this.listView5.Size = new Size(326, 420);
            this.listView5.TabIndex = 34;
            this.listView5.UseCompatibleStateImageBehavior = false;
            this.listView5.View = View.Details;
            this.columnHeader10.Text = "\x2463생명과환경";
            this.columnHeader10.Width = 240;
            this.listView6.Columns.AddRange(new ColumnHeader[1]
            {
                this.columnHeader11
            });
            this.listView6.FullRowSelect = true;
            this.listView6.HideSelection = false;
            this.listView6.Location = new Point(10, 262);
            this.listView6.Margin = new Padding(3, 4, 3, 4);
            this.listView6.Name = "listView6";
            this.listView6.Size = new Size(326, 420);
            this.listView6.TabIndex = 35;
            this.listView6.UseCompatibleStateImageBehavior = false;
            this.listView6.View = View.Details;
            this.columnHeader11.Text = "\x2464과학과기술";
            this.columnHeader11.Width = 240;
            this.listView7.Columns.AddRange(new ColumnHeader[1]
            {
                this.columnHeader12
            });
            this.listView7.FullRowSelect = true;
            this.listView7.HideSelection = false;
            this.listView7.Location = new Point(10, 262);
            this.listView7.Margin = new Padding(3, 4, 3, 4);
            this.listView7.Name = "listView7";
            this.listView7.Size = new Size(326, 420);
            this.listView7.TabIndex = 36;
            this.listView7.UseCompatibleStateImageBehavior = false;
            this.listView7.View = View.Details;
            this.columnHeader12.Text = "\x2465예술과체육";
            this.columnHeader12.Width = 240;
            this.listView8.Columns.AddRange(new ColumnHeader[1]
            {
                this.columnHeader13
            });
            this.listView8.FullRowSelect = true;
            this.listView8.HideSelection = false;
            this.listView8.Location = new Point(10, 262);
            this.listView8.Margin = new Padding(3, 4, 3, 4);
            this.listView8.Name = "listView8";
            this.listView8.Size = new Size(326, 420);
            this.listView8.TabIndex = 37;
            this.listView8.UseCompatibleStateImageBehavior = false;
            this.listView8.View = View.Details;
            this.columnHeader13.Text = "\x2466융·복합 영역";
            this.columnHeader13.Width = 240;
            this.label19.AutoSize = true;
            this.label19.Location = new Point(7, 701);
            this.label19.Name = "label19";
            this.label19.Size = new Size(15, 15);
            this.label19.TabIndex = 38;
            this.label19.Text = "0";
            this.label20.AutoSize = true;
            this.label20.Location = new Point(101, 701);
            this.label20.Name = "label20";
            this.label20.Size = new Size(15, 15);
            this.label20.TabIndex = 39;
            this.label20.Text = "0";
            this.label21.AutoSize = true;
            this.label21.Location = new Point(200, 701);
            this.label21.Name = "label21";
            this.label21.Size = new Size(15, 15);
            this.label21.TabIndex = 40;
            this.label21.Text = "0";
            this.label22.AutoSize = true;
            this.label22.Location = new Point(309, 701);
            this.label22.Name = "label22";
            this.label22.Size = new Size(15, 15);
            this.label22.TabIndex = 41;
            this.label22.Text = "0";
            this.label23.AutoSize = true;
            this.label23.Location = new Point(51, 730);
            this.label23.Name = "label23";
            this.label23.Size = new Size(15, 15);
            this.label23.TabIndex = 42;
            this.label23.Text = "0";
            this.label24.AutoSize = true;
            this.label24.Location = new Point(152, 730);
            this.label24.Name = "label24";
            this.label24.Size = new Size(15, 15);
            this.label24.TabIndex = 43;
            this.label24.Text = "0";
            this.label25.AutoSize = true;
            this.label25.Location = new Point(241, 730);
            this.label25.Name = "label25";
            this.label25.Size = new Size(15, 15);
            this.label25.TabIndex = 44;
            this.label25.Text = "0";
            this.label26.AutoSize = true;
            this.label26.Location = new Point(669, 14);
            this.label26.Name = "label26";
            this.label26.Size = new Size(92, 15);
            this.label26.TabIndex = 46;
            this.label26.Text = "내 이수 과목";
            this.label27.AutoSize = true;
            this.label27.Location = new Point(357, 244);
            this.label27.Name = "label27";
            this.label27.Size = new Size(102, 15);
            this.label27.TabIndex = 47;
            this.label27.Text = "이수 기초교양";
            this.label28.AutoSize = true;
            this.label28.Location = new Point(360, 505);
            this.label28.Name = "label28";
            this.label28.Size = new Size(102, 15);
            this.label28.TabIndex = 48;
            this.label28.Text = "이수 공통교양";
            this.label29.AutoSize = true;
            this.label29.Location = new Point(11, 238);
            this.label29.Name = "label29";
            this.label29.Size = new Size(102, 15);
            this.label29.TabIndex = 49;
            this.label29.Text = "이수 핵심교양";
            this.listView9.Columns.AddRange(new ColumnHeader[2]
            {
                this.columnHeader16,
                this.columnHeader14
            });
            this.listView9.Font = new Font("굴림체", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 129);
            this.listView9.FullRowSelect = true;
            this.listView9.HideSelection = false;
            this.listView9.Location = new Point(362, 262);
            this.listView9.Margin = new Padding(3, 4, 3, 4);
            this.listView9.Name = "listView9";
            this.listView9.Size = new Size(289, 238);
            this.listView9.TabIndex = 50;
            this.listView9.UseCompatibleStateImageBehavior = false;
            this.listView9.View = View.Details;
            this.columnHeader16.Text = "과목명";
            this.columnHeader16.Width = 209;
            this.columnHeader14.Text = "학점";
            this.columnHeader14.Width = 36;
            this.listView10.Columns.AddRange(new ColumnHeader[1]
            {
                this.columnHeader15
            });
            this.listView10.FullRowSelect = true;
            listViewGroup1.Header = "필수교과목";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "선택교과목";
            listViewGroup2.Name = "listViewGroup2";
            this.listView10.Groups.AddRange(new ListViewGroup[2]
            {
                listViewGroup1,
                listViewGroup2
            });
            this.listView10.HideSelection = false;
            listViewItem1.Group = listViewGroup1;
            listViewItem2.Group = listViewGroup1;
            listViewItem3.Group = listViewGroup1;
            listViewItem4.Group = listViewGroup1;
            listViewItem5.Group = listViewGroup1;
            listViewItem6.Group = listViewGroup2;
            listViewItem7.Group = listViewGroup2;
            listViewItem8.Group = listViewGroup2;
            listViewItem9.Group = listViewGroup2;
            listViewItem10.Group = listViewGroup2;
            listViewItem11.Group = listViewGroup2;
            listViewItem12.Group = listViewGroup2;
            this.listView10.Items.AddRange(new ListViewItem[12]
            {
                listViewItem1,
                listViewItem2,
                listViewItem3,
                listViewItem4,
                listViewItem5,
                listViewItem6,
                listViewItem7,
                listViewItem8,
                listViewItem9,
                listViewItem10,
                listViewItem11,
                listViewItem12
            });
            this.listView10.Location = new Point(364, 522);
            this.listView10.Margin = new Padding(3, 2, 3, 2);
            this.listView10.Name = "listView10";
            this.listView10.Size = new Size(287, 193);
            this.listView10.TabIndex = 51;
            this.listView10.UseCompatibleStateImageBehavior = false;
            this.listView10.View = View.SmallIcon;
            this.columnHeader15.Text = "과목명";
            this.columnHeader15.Width = 153;
            this.label30.AutoSize = true;
            this.label30.Location = new Point(360, 730);
            this.label30.Name = "label30";
            this.label30.Size = new Size(140, 15);
            this.label30.TabIndex = 52;
            this.label30.Text = "필수교과목 : 0 학점";
            this.label31.AutoSize = true;
            this.label31.Location = new Point(525, 730);
            this.label31.Name = "label31";
            this.label31.Size = new Size(140, 15);
            this.label31.TabIndex = 53;
            this.label31.Text = "선택교과목 : 0 학점";
            this.listView11.Columns.AddRange(new ColumnHeader[1]
            {
                this.columnHeader21
            });
            this.listView11.HideSelection = false;
            this.listView11.Location = new Point(1072, 20);
            this.listView11.Margin = new Padding(3, 2, 3, 2);
            this.listView11.Name = "listView11";
            this.listView11.Size = new Size(258, 235);
            this.listView11.TabIndex = 54;
            this.listView11.UseCompatibleStateImageBehavior = false;
            this.listView11.View = View.Details;
            this.listView12.Columns.AddRange(new ColumnHeader[1]
            {
                this.columnHeader22
            });
            this.listView12.HideSelection = false;
            this.listView12.Location = new Point(1072, 244);
            this.listView12.Margin = new Padding(3, 2, 3, 2);
            this.listView12.Name = "listView12";
            this.listView12.Size = new Size(258, 235);
            this.listView12.TabIndex = 55;
            this.listView12.UseCompatibleStateImageBehavior = false;
            this.listView12.View = View.Details;
            this.listView13.Columns.AddRange(new ColumnHeader[1]
            {
                this.columnHeader23
            });
            this.listView13.HideSelection = false;
            this.listView13.Location = new Point(1072, 480);
            this.listView13.Margin = new Padding(3, 2, 3, 2);
            this.listView13.Name = "listView13";
            this.listView13.Size = new Size(258, 235);
            this.listView13.TabIndex = 56;
            this.listView13.UseCompatibleStateImageBehavior = false;
            this.listView13.View = View.Details;
            this.listView14.Columns.AddRange(new ColumnHeader[4]
            {
                this.columnHeader17,
                this.columnHeader18,
                this.columnHeader19,
                this.columnHeader20
            });
            this.listView14.FullRowSelect = true;
            this.listView14.HideSelection = false;
            this.listView14.Location = new Point(672, 372);
            this.listView14.Margin = new Padding(3, 2, 3, 2);
            this.listView14.Name = "listView14";
            this.listView14.Size = new Size(364, 373);
            this.listView14.TabIndex = 57;
            this.listView14.UseCompatibleStateImageBehavior = false;
            this.listView14.View = View.Details;
            this.columnHeader17.Text = "학기";
            this.columnHeader17.Width = 40;
            this.columnHeader18.Text = "과목명";
            this.columnHeader18.Width = 197;
            this.columnHeader19.Text = "학점";
            this.columnHeader19.Width = 44;
            this.columnHeader20.Text = "";
            this.columnHeader20.Width = 0;
            this.label32.AutoSize = true;
            this.label32.Location = new Point(669, 354);
            this.label32.Name = "label32";
            this.label32.Size = new Size(122, 15);
            this.label32.TabIndex = 58;
            this.label32.Text = "내 학과 전공과목";
            this.pictureBox1.Image = (Image) Resources._2020_04_03_20_30_22;
            this.pictureBox1.Location = new Point(8, 14);
            this.pictureBox1.Margin = new Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(657, 214);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.AutoScaleDimensions = new SizeF(8f, 15f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(1354, 758);
            this.Controls.Add((Control) this.label32);
            this.Controls.Add((Control) this.listView14);
            this.Controls.Add((Control) this.listView13);
            this.Controls.Add((Control) this.listView12);
            this.Controls.Add((Control) this.listView11);
            this.Controls.Add((Control) this.ID);
            this.Controls.Add((Control) this.button1);
            this.Controls.Add((Control) this.PW);
            this.Controls.Add((Control) this.label31);
            this.Controls.Add((Control) this.label30);
            this.Controls.Add((Control) this.listView10);
            this.Controls.Add((Control) this.listView9);
            this.Controls.Add((Control) this.label29);
            this.Controls.Add((Control) this.label28);
            this.Controls.Add((Control) this.label27);
            this.Controls.Add((Control) this.label26);
            this.Controls.Add((Control) this.label25);
            this.Controls.Add((Control) this.label24);
            this.Controls.Add((Control) this.label23);
            this.Controls.Add((Control) this.label22);
            this.Controls.Add((Control) this.label21);
            this.Controls.Add((Control) this.label20);
            this.Controls.Add((Control) this.label19);
            this.Controls.Add((Control) this.comboBox1);
            this.Controls.Add((Control) this.listView2);
            this.Controls.Add((Control) this.label18);
            this.Controls.Add((Control) this.label17);
            this.Controls.Add((Control) this.label16);
            this.Controls.Add((Control) this.label15);
            this.Controls.Add((Control) this.label14);
            this.Controls.Add((Control) this.label13);
            this.Controls.Add((Control) this.label11);
            this.Controls.Add((Control) this.label10);
            this.Controls.Add((Control) this.label9);
            this.Controls.Add((Control) this.label8);
            this.Controls.Add((Control) this.label7);
            this.Controls.Add((Control) this.label6);
            this.Controls.Add((Control) this.label5);
            this.Controls.Add((Control) this.label4);
            this.Controls.Add((Control) this.label2);
            this.Controls.Add((Control) this.label1);
            this.Controls.Add((Control) this.listView1);
            this.Controls.Add((Control) this.enterY);
            this.Controls.Add((Control) this.name);
            this.Controls.Add((Control) this.maj2nm);
            this.Controls.Add((Control) this.majnm);
            this.Controls.Add((Control) this.studentnumber);
            this.Controls.Add((Control) this.listView8);
            this.Controls.Add((Control) this.listView7);
            this.Controls.Add((Control) this.listView6);
            this.Controls.Add((Control) this.listView5);
            this.Controls.Add((Control) this.listView4);
            this.Controls.Add((Control) this.listView3);
            this.Controls.Add((Control) this.pictureBox1);
            this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
            this.Margin = new Padding(3, 2, 3, 2);
            this.Name = nameof(Form1);
            this.Text = "졸업자가진단프로그램";
            this.Load += new EventHandler(this.Form1_Load);
            ((ISupportInitialize) this.pictureBox1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}