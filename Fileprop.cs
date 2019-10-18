using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace FileManageSystem
{
    public class Fileprop
    {
        public string name { set; get; }
        public string title { set; get; }
        public string artist { set; get; }
        public string bitrate { set; get; }
        public string strduration { set; get; }

        public long filesize { set; get; }
        public double duration { set; get; }
        public string path { set; get; }

        public Fileprop(string filepath)
        {
            var file = ShellFile.FromFilePath(filepath);
            FileInfo fileinfo = new FileInfo(filepath);

            name = fileinfo.Name;
            path = fileinfo.FullName;
            filesize = fileinfo.Length/1000000;
            try { title = file.Properties.System.Title.Value; } catch { title = "--"; }
            try
            {
                string[] array = file.Properties.System.Author.Value;
                artist = string.Join("", array);

            } catch { artist = "--" ; }
            try
            {
                duration = TimeSpan.FromTicks((long)(ulong)file.Properties.System.Media.Duration.ValueAsObject).TotalMinutes;
                double copy = duration;
                int min = 0;
                while (copy > 1) { copy--; min++; }
                int second = Convert.ToInt32(copy * 60.0);
                strduration = min.ToString() + ":" + second.ToString();
                    
            }
            catch { duration = 0; }
            try { bitrate = file.Properties.System.Audio.EncodingBitrate.Value.ToString(); } catch { bitrate = "--"; }
        }


        public Fileprop(string inname,string intitle,string inartist, string inbitrate,string instrduration,string infilesize,string induration,string inpath)
        {
            name = inname;
            title = intitle;
            artist = inartist;
            bitrate = inbitrate;
            strduration = instrduration;
            filesize = Convert.ToInt64(infilesize);
            duration = Convert.ToDouble(induration);
            path = inpath;
        }

        public bool checkExist(List<Fileprop> targetlist, Fileprop inputfile)
        {
            foreach (Fileprop tar in targetlist)
            {
                if (tar.path == inputfile.path) return true;
                else if (tar.duration == inputfile.duration && tar.filesize == inputfile.filesize && tar.name == inputfile.name)
                    return true;
            }
            return false;
        }

        static public Fileprop searchByPath(List<Fileprop> targetlist, string mypath, out bool IsExist)
        {

            foreach (Fileprop tar in targetlist)
            {
                if (tar.path == mypath)
                {
                    IsExist = true;
                    return tar;
                }
            }
            IsExist = false;
            return null;
        }

        static public List<Fileprop> comparelist(List<Fileprop> inmainlist, List<Fileprop> insublist)
        {
            List<Fileprop> filenotexist = new List<Fileprop>();
            List<Fileprop> mainlist = new List<Fileprop>(inmainlist);
            List<Fileprop> sublist = new List<Fileprop>(insublist);

            foreach (Fileprop mainfile in mainlist)
            {
                foreach (Fileprop subfile in sublist)
                {
                    if((mainfile.filesize == subfile.filesize) && (mainfile.duration == subfile.duration) && (mainfile.bitrate == subfile.bitrate))
                    {
                        try { sublist.Remove(subfile); } catch { }
                        continue;
                    }
                }
                filenotexist.Add(mainfile);
            }  
            return filenotexist;
        }

        static public List<Fileprop> comparelist2(List<Fileprop> inmainlist, List<Fileprop> insublist)
        {
            List<Fileprop> filenotexist = new List<Fileprop>();
            List<Fileprop> mainlist = new List<Fileprop>(inmainlist);
            List<Fileprop> sublist = new List<Fileprop>(insublist);


            for (int main = 0; main < mainlist.Count; main++)
            {
                bool exist = new bool();
                for (int sub = 0; sub < sublist.Count; sub++)
                {
                    if ((mainlist[main].filesize == sublist[sub].filesize) && (mainlist[main].duration == sublist[sub].duration) && (mainlist[main].bitrate == sublist[sub].bitrate))
                    {
                        try { sublist.RemoveAt(sub); exist = true; } catch { }
                        break;
                    }
                }
                if(!exist) filenotexist.Add(mainlist[main]);
            }
            return filenotexist;
        }

    }


    public class Register
    {
        public string name { set; get; }
        public string path { set; get; }

        public Register()
        {
            name = "";
            path = "";
        }

        public Register(string na, string pa)
        {
            name = na;
            path = pa;
        }
    }

    public class StringValue
    {
        public StringValue(string s)
        {
            _value = s;
        }
        public string Value { get { return _value; } set { _value = value; } }
        string _value;


        static public StringValue search(List<StringValue> targetlist, string mystring, out bool IsExist)
        {

            foreach (StringValue tar in targetlist)
            {
                if (tar._value == mystring)
                {
                    IsExist = true;
                    return tar;
                }
            }
            IsExist = false;
            return null;
        }

        static public List<StringValue> comparelist2(List<StringValue> inmainlist, List<StringValue> insublist)
        {
            List<StringValue> filenotexist = new List<StringValue>();
            List<StringValue> mainlist = new List<StringValue>(inmainlist);
            List<StringValue> sublist = new List<StringValue>(insublist);


            for (int main = 0; main < mainlist.Count; main++)
            {
                bool exist = new bool();
                DirectoryInfo maindir = new DirectoryInfo(mainlist[main].Value);
                for (int sub = 0; sub < sublist.Count; sub++)
                {
                    DirectoryInfo subdir = new DirectoryInfo(sublist[sub].Value);
                    if (maindir.Name == subdir.Name)
                    {
                        try { sublist.RemoveAt(sub); exist = true; } catch { }
                        break;
                    }
                }
                if(!exist) filenotexist.Add(mainlist[main]);
            }
            return filenotexist;
        }


    }

}