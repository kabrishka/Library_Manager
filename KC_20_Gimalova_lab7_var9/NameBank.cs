using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KC_20_Gimalova_lab7_var9
{
    internal class NameBank
    {
        public static string nameJournal;
        public static string nameArticle;
        public static string nameAuthor;

        //для записи
        public static string imgLoc;
        public static byte[] byteImg;

        public static int selectedRowIndexForChange;
        public static DataGridViewRow row;

        public static int ID;
        public static int numVolume;
        public static int numJournal;
        public static int varFirstPage;
        public static int varEndPage;
        public static int varYear;
    }
}
