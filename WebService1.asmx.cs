using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace practicawebservice
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public String burbuja(int n)
        {
            int[] numero = new int[] {};

            for (int i=0; i < numero.Length; i++)
            {

                for (int j=0; j< numero.Length; j++)
                {
                    if (numero[j] > numero[j + 1] )
                    {
                        int aux = numero[j];
                        numero[j] = numero[j + 1];
                        numero[j + 1] = aux;
                    }

                } 

            }
            return "los numeros son: " + n.ToString();
        }
        [WebMethod]
        public int Fibonacci(int numero)
        {
            int f = 0;
            int t1 = 1;
            int t2;
            for (int i = 1; i <= numero; i++)
            {

                t2 = f;
                f = t1 + f;
                t1 = t2;

            }
            return t1;
        }
    }
}
