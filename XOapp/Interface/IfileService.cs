using System;
using System.Collections.Generic;
using System.Text;

namespace XOapp.Interface
{
    public  interface IfileService
    {
        void CreateFile( string Values);
        string[] ReadFile();
    }
}
