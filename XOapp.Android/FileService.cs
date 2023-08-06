using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using XOapp.Droid;
using XOapp.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(FileService))]
namespace XOapp.Droid
{
    public class FileService : IfileService
    {
        public string getRootPath()
        {
            return Application.Context.GetExternalFilesDir(null).ToString();
        }
        public void CreateFile( string Values)
        {
            var fileName = "resources.txt";
            var destination = Path.Combine(getRootPath(), fileName);
            File.WriteAllText(destination, Values);
        }
        public string[] ReadFile() {
            var fileName = "resources.txt";
            var destination = Path.Combine(getRootPath(), fileName);
            if (!File.Exists(destination))
            {
                CreateFile("______");
            }
            string[] lines = File.ReadAllLines(destination);
            return lines;
        }

    }
}