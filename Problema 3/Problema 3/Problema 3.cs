using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    class parteUnoyDos
    {
        
        private string nombre { set; get; }
        private string apellidoP { get; set; }
        private string apellidoM { set; get; }
        private string año { set; get; }
        private string mes { set; get; }
        private string dia { set; get; }
        
        public parteUnoyDos(string nombre, string p, string m)
        {
            Console.WriteLine("Datos recibidos");
            nombre = nombre.ToUpper();
            string[] sep = nombre.Split(new Char[] { ' ' });
            if (p.Length == 1 || p.Length == 2)
            {
                this.nombre = nombre[0].ToString().ToUpper() + nombre[1].ToString().ToUpper();
                this.apellidoM = m[0].ToString().ToUpper();
                this.apellidoP = p[0].ToString().ToUpper();
            }
            else if (sep.Length == 2)
            {
                if (sep[0].Equals("MARIA") || sep[0].Equals("JOSE"))
                {
                    this.nombre = (sep[1].ToString())[0].ToString().ToUpper();
                    this.apellidoM = m[0].ToString().ToUpper();
                    int re = 1000;
                    p = p.ToUpper();
                    char[] ve = { 'A', 'E', 'I', 'O', 'U' };

                    for (int u = 0; u < ve.Length; u++)
                    {
                        if (p.IndexOf(ve[u]) == -1) continue;
                        if (p.IndexOf(ve[u]) <= re)
                            re = p.IndexOf(ve[u]);
                    }
                    this.apellidoP = p[0].ToString().ToUpper() + p[re].ToString().ToUpper();
                }
                else
                {
                    this.nombre = (sep[0].ToString())[0].ToString().ToUpper();
                    this.apellidoM = m[0].ToString().ToUpper();
                    int re = 1000;
                    p = p.ToUpper();
                    char[] ve = { 'A', 'E', 'I', 'O', 'U' };

                    for (int u = 0; u < ve.Length; u++)
                    {
                        if (p.IndexOf(ve[u]) == -1) continue;
                        if (p.IndexOf(ve[u]) <= re)
                            re = p.IndexOf(ve[u]);
                    }
                    this.apellidoP = p[0].ToString().ToUpper() + p[re].ToString().ToUpper();
                }
            }
            else if (string.IsNullOrEmpty(p) == true)
            {
                this.apellidoP = null;
                this.apellidoM = m[0].ToString().ToUpper() + m[1].ToString().ToUpper();
                this.nombre = nombre[0].ToString().ToUpper() + nombre[1].ToString().ToUpper();
            }
            else if (string.IsNullOrEmpty(m) == true)
            {
                this.apellidoM = null;
                this.apellidoP = p[0].ToString().ToUpper() + p[1].ToString().ToUpper();
                this.nombre = nombre[0].ToString().ToUpper() + nombre[1].ToString().ToUpper();
            }
            else
            {
                this.nombre = nombre[0].ToString().ToUpper();//PARA EL NOMBRE
                int r = 1000;
                p = p.ToUpper();
                char[] v = { 'A', 'E', 'I', 'O', 'U' };

                for (int u = 0; u < v.Length; u++)
                {
                    if (p.IndexOf(v[u]) == -1) continue;
                    if (p.IndexOf(v[u]) <= r)
                        r = p.IndexOf(v[u]);
                }
                this.apellidoP = p[0].ToString().ToUpper() + p[r].ToString().ToUpper();
                this.apellidoM = m[0].ToString().ToUpper();
            }

        }
        public void setAño(int n)
        {
            this.año = n.ToString()[n.ToString().Length - 2].ToString() + n.ToString()[n.ToString().Length - 1].ToString();
        }
        public string getAño()
        {
            return this.año;
        }
        public void setDia(int n)
        {
            if (n.ToString().Length == 1)
            {
                this.dia = "0{0}" + n.ToString();
            }
            this.dia = n.ToString();
        }
        public string getDia()
        {
            return this.dia;
        }
        public void setMes(string n)
        {

            switch (n.ToUpper())
            {
                case "ENERO":
                    this.mes = "01";
                    break;
                case "FEBRERO":
                    this.mes = "02";
                    break;
                case "MARZO":
                    this.mes = "03";
                    break;
                case "ABRIL":
                    this.mes = "04";
                    break;
                case "MAYO":
                    this.mes = "05";
                    break;
                case "JUNIO":
                    this.mes = "06";
                    break;
                case "JULIO":
                    this.mes = "07";
                    break;
                case "AGOSTO":
                    this.mes = "08";
                    break;
                case "SEPTIEMBRE":
                    this.mes = "09";
                    break;
                case "OCTUBRE":
                    this.mes = "10";
                    break;
                case "NOVIEMBRE":
                    this.mes = "11";
                    break;
                case "DICIEMBRE":
                    this.mes = "12";
                    break;
            }
        }
        public string getMes()
        {
            return this.mes;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string getApellidop()
        {
            return this.apellidoP;
        }
        public string getApellidom()
        {
            return this.apellidoM;
        }


    }
    class sexo
    {
        private string sex { set; get; }

        public sexo(string sex)
        {
            sex = sex.ToUpper();
            if (sex.Equals("HOMBRE") == true) this.sex = "H";
            if (sex.Equals("MUJER") == true) this.sex = "M";
        }
        public string getSexo()
        {
            return this.sex;
        }
    }
    class estado
    {
        private string lugar { set; get; }
        public estado(string e)
        {
            string[] sep = e.Split(new Char[] { ' ' });
            if (sep.Length >= 2)
            {
                if (e.Equals("CIUDAD DE MEXICO") == true) this.lugar = "DF";
                else
                {
                    char primero = sep[0][0];
                    char ultimo = sep[sep.Length - 1][0];
                    this.lugar = primero.ToString() + ultimo.ToString();
                }
            }
            else if (e.Equals("CAMPECHE") == true) this.lugar = "CC";
            else if (e.Equals("QUERETARO") == true) this.lugar = "QT";
            else
            {
                int re = 0;
                e = e.ToUpper();
                char[] ve = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
                for (int u = 0; u < ve.Length; u++)
                {
                    if (e.IndexOf(ve[u]) == -1) continue;
                    if (e.IndexOf(ve[u]) >= re)
                        re = e.IndexOf(ve[u]);
                }
                this.lugar = e[0].ToString() + e[re].ToString();
            }
        }
        public string getEstado()
        {
            return this.lugar;
        }
    }
    class parteTres
    {
        private string nombre { set; get; }
        private string apellidop { set; get; }
        private string apellidom { set; get; }

        public parteTres(string n, string ap, string am)
        {
            int re = 1000;
            n = n.Remove(0, 1).ToUpper();
            char[] ve = { 'B', 'C', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'X', 'Y', 'Z' };
            for (int u = 0; u < ve.Length; u++)
            {
                if (n.IndexOf(ve[u]) == -1) continue;
                if (n.IndexOf(ve[u]) <= re)
                    re = n.IndexOf(ve[u]);
            }
            this.nombre = n[re].ToString();

            re = 1000;
            ap = ap.Remove(0, 1).ToUpper();
            for (int u = 0; u < ve.Length; u++)
            {
                if (ap.IndexOf(ve[u]) == -1) continue;
                if (ap.IndexOf(ve[u]) <= re)
                    re = ap.IndexOf(ve[u]);
            }
            this.apellidop = ap[re].ToString();
            re = 1000;
            am = am.Remove(0, 1).ToUpper();
            for (int u = 0; u < ve.Length; u++)
            {
                if (am.IndexOf(ve[u]) == -1) continue;
                if (am.IndexOf(ve[u]) <= re)
                    re = am.IndexOf(ve[u]);
            }
            this.apellidom = am[re].ToString();
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public string getApellidop()
        {
            return this.apellidop;
        }
        public string getApellidom()
        {
            return this.apellidom;
        }
    }
    class digito
    {
        private string cadena { set; get; }
        public digito(string c)
        {
            string tmp = String.Copy(c);
            string tmp2 = "";
            int s = 0, i = 12, d, r;
            string[] uno = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "&", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", " ", "Ñ" };
            string[] dos = { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38" };

            for (int jg = 0; jg < uno.Length; jg++) tmp = tmp.Replace(uno[jg], dos[jg]);
            for (int y = c.Length - 1; y >= 0; y--) tmp2 = tmp2 + c[y].ToString();
            for (int t = 0; t < tmp.Length; t++)
            {
                if (t == tmp.Length - 1) continue;
                s = s + Convert.ToInt32(tmp.Substring(t, 2)) * (i + 1);
                t++;
                i--;
            }
            d = s / 11;
            r = s % 11;
            if (r > 0) this.cadena = (11 - r).ToString();
            else if (r == 10) this.cadena = "A";
            else this.cadena = 0.ToString();
        }
        public string getDigito()
        {
            return this.cadena;
        }
    }
    class Homoclave
    {
        
        private string nombre { set; get; }
        
        public Homoclave(string nombre)
        {
            nombre = nombre.ToUpper();
            string[] uno = { " ", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "&", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Ñ" };
            string[] dos = { "0", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "21", "22", "23", "24", "25", "26", "27", "28", "29", "32", "33", "34", "35", "36", "37", "38", "39", "40" };
            for (int jg = 0; jg < uno.Length; jg++)
            {
                nombre = nombre.Replace(uno[jg], dos[jg]);
            }
            nombre = "0" + nombre;
            int s = 0;
            int m;
            string t;
            string g;
            for (int y = 0; y < nombre.Length; y++)
            {
                if (y == nombre.Length - 1) break;
                g = nombre[y].ToString() + nombre[y + 1].ToString();
                t = nombre[y + 1].ToString();
                m = Convert.ToInt32(g) * Convert.ToInt32(t);
                s += m;
            }
            string tmp = s.ToString();
            string h = "";
            for (int f = tmp.Length - 3; f < tmp.Length; f++)
            {
                h = h + tmp[f];
            }
            int final = Convert.ToInt32(h);
            string residuo, cociente;
            cociente = (final / 34).ToString();
            residuo = (final % 34).ToString();
            switch (cociente)
            {
                case "0":
                    cociente = cociente.Replace("0", "1");
                    break;
                case "1":
                    cociente = cociente.Replace("1", "2");
                    break;
                case "2":
                    cociente = cociente.Replace("2", "3");
                    break;
                case "3":
                    cociente = cociente.Replace("3", "4");
                    break;
                case "4":
                    cociente = cociente.Replace("4", "5");
                    break;
                case "5":
                    cociente = cociente.Replace("5", "6");
                    break;
                case "6":
                    cociente = cociente.Replace("6", "7");
                    break;
                case "7":
                    cociente = cociente.Replace("7", "8");
                    break;
                case "8":
                    cociente = cociente.Replace("8", "9");
                    break;
                case "9":
                    cociente = cociente.Replace("9", "A");
                    break;
                case "10":
                    cociente = cociente.Replace("10", "B");
                    break;
                case "11":
                    cociente = cociente.Replace("11", "C");
                    break;
                case "12":
                    cociente = cociente.Replace("12", "D");
                    break;
                case "13":
                    cociente = cociente.Replace("13", "E");
                    break;
                case "14":
                    cociente = cociente.Replace("14", "F");
                    break;
                case "15":
                    cociente = cociente.Replace("15", "G");
                    break;
                case "16":
                    cociente = cociente.Replace("16", "H");
                    break;
                case "17":
                    cociente = cociente.Replace("17", "I");
                    break;
                case "18":
                    cociente = cociente.Replace("18", "J");
                    break;
                case "19":
                    cociente = cociente.Replace("19", "K");
                    break;
                case "20":
                    cociente = cociente.Replace("20", "L");
                    break;
                case "21":
                    cociente = cociente.Replace("21", "M");
                    break;
                case "22":
                    cociente = cociente.Replace("22", "N");
                    break;
                case "23":
                    cociente = cociente.Replace("23", "P");
                    break;
                case "24":
                    cociente = cociente.Replace("24", "Q");
                    break;
                case "25":
                    cociente = cociente.Replace("25", "R");
                    break;
                case "26":
                    cociente = cociente.Replace("26", "S");
                    break;
                case "27":
                    cociente = cociente.Replace("27", "T");
                    break;
                case "28":
                    cociente = cociente.Replace("28", "U");
                    break;
                case "29":
                    cociente = cociente.Replace("29", "V");
                    break;
                case "30":
                    cociente = cociente.Replace("30", "W");
                    break;
                case "31":
                    cociente = cociente.Replace("31", "X");
                    break;
                case "32":
                    cociente = cociente.Replace("32", "Y");
                    break;
                case "33":
                    cociente = cociente.Replace("33", "Z");
                    break;
            }
            switch (residuo)
            {
                case "0":
                    residuo = residuo.Replace("0", "1");
                    break;
                case "1":
                    residuo = residuo.Replace("1", "2");
                    break;
                case "2":
                    residuo = residuo.Replace("2", "3");
                    break;
                case "3":
                    residuo = residuo.Replace("3", "4");
                    break;
                case "4":
                    residuo = residuo.Replace("4", "5");
                    break;
                case "5":
                    residuo = residuo.Replace("5", "6");
                    break;
                case "6":
                    residuo = residuo.Replace("6", "7");
                    break;
                case "7":
                    residuo = residuo.Replace("7", "8");
                    break;
                case "8":
                    residuo = residuo.Replace("8", "9");
                    break;
                case "9":
                    residuo = residuo.Replace("9", "A");
                    break;
                case "10":
                    residuo = residuo.Replace("10", "B");
                    break;
                case "11":
                    residuo = residuo.Replace("11", "C");
                    break;
                case "12":
                    residuo = residuo.Replace("12", "D");
                    break;
                case "13":
                    residuo = residuo.Replace("13", "E");
                    break;
                case "14":
                    residuo = residuo.Replace("14", "F");
                    break;
                case "15":
                    residuo = residuo.Replace("15", "G");
                    break;
                case "16":
                    residuo = residuo.Replace("16", "H");
                    break;
                case "17":
                    residuo = residuo.Replace("17", "I");
                    break;
                case "18":
                    residuo = residuo.Replace("18", "J");
                    break;
                case "19":
                    residuo = residuo.Replace("19", "K");
                    break;
                case "20":
                    residuo = residuo.Replace("20", "L");
                    break;
                case "21":
                    residuo = residuo.Replace("21", "M");
                    break;
                case "22":
                    residuo = residuo.Replace("22", "N");
                    break;
                case "23":
                    residuo = residuo.Replace("23", "P");
                    break;
                case "24":
                    residuo = residuo.Replace("24", "Q");
                    break;
                case "25":
                    residuo = residuo.Replace("25", "R");
                    break;
                case "26":
                    residuo = residuo.Replace("26", "S");
                    break;
                case "27":
                    residuo = residuo.Replace("27", "T");
                    break;
                case "28":
                    residuo = residuo.Replace("28", "U");
                    break;
                case "29":
                    residuo = residuo.Replace("29", "V");
                    break;
                case "30":
                    residuo = residuo.Replace("30", "W");
                    break;
                case "31":
                    residuo = residuo.Replace("31", "X");
                    break;
                case "32":
                    residuo = residuo.Replace("32", "Y");
                    break;
                case "33":
                    residuo = residuo.Replace("33", "Z");
                    break;
            }
            this.nombre = cociente + residuo;
        }
        public string getNombre()
        {
            return this.nombre;
        }
    }
    class diferencia
    {
        private string numero { set; get; }

        public diferencia(string año)
        {
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random aleatorio = new Random();
            if (Convert.ToInt32(año) >= 2000)
            {
                int j = aleatorio.Next(0, letras.Length - 1);
                this.numero = letras[j].ToString();
            }
            else
            {
                int y = aleatorio.Next(0, numeros.Length - 1);
                this.numero = numeros[y].ToString();
            }
        }

        public string getNumero()
        {
            return this.numero;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            string nombre, ap, am, mes, año, dia, sexo, lugar;
            int c;
            Console.WriteLine("\t\tSolicitud de CURP");
            Console.WriteLine("\t\tBienvenido, usuario.\n \nFavor de proporcionar los datos para su CURP  \n ");
            do
                {
                    c = 0;
                    Console.Write("Ingrese su nombre o nombres: ");
                    nombre = Console.ReadLine().Trim();
                    for (int t = 0; t < nombre.Length; t++)
                    {
                        if (Char.IsLetter(nombre[t]) == false)
                            c++;
                        if (Char.IsWhiteSpace(nombre[t]) == true)
                            c--;
                    }Console.WriteLine();
                } while (c > 0);
            do
                {
                    c = 0;
                    Console.Write("Ingrese su apellido paterno: ");
                    ap = Console.ReadLine().Trim();
                    for (int t = 0; t < ap.Length; t++)
                    {
                        if (Char.IsLetter(ap[t]) == false)
                            c++;
                        if (Char.IsWhiteSpace(ap[t]) == true)
                            c--;
                    }
                    Console.WriteLine();
                } while (c > 0);
            do
                {
                    c = 0;
                    Console.Write("Ingrese su apellido materno: ");
                    am = Console.ReadLine().Trim();
                    for (int t = 0; t < am.Length; t++)
                    {
                        if (Char.IsLetter(am[t]) == false) c++;
                        if (Char.IsWhiteSpace(am[t]) == true) c--;
                    }
                Console.WriteLine();
                } while (c > 0);
            do
                {
                    do
                    {
                        c = 0;
                        Console.Write("Ingrese el día en el que nació: ");
                        dia = Console.ReadLine().Trim();
                        for (int y = 0; y < dia.Length; y++)
                        {
                            if (Char.IsNumber(dia[y]) == false) c++;
                        }
                    } while (c > 0);
                Console.WriteLine();
                } while (Convert.ToInt32(dia) <= 0 || Convert.ToInt32(dia) > 31);
            do
                {
                    do
                    {
                        c = 0;
                        Console.Write("Ingrese su mes de nacimiento con letra (por ejemplo: agosto): ");
                        mes = Console.ReadLine().Trim();
                        mes = mes.ToUpper();
                        for (int t = 0; t < mes.Length; t++)
                        {
                            if (Char.IsLetter(mes[t]) == false)
                                c++;
                            if (Char.IsWhiteSpace(mes[t]) == true)
                                c--;
                        }
                    } while (c > 0);
                Console.WriteLine();
                } while (mes.Equals("ENERO") == false & mes.Equals("FEBRERO") == false & mes.Equals("MARZO") == false & mes.Equals("ABRIL") == false & mes.Equals("MAYO") == false & mes.Equals("JUNIO") == false & mes.Equals("JULIO") == false & mes.Equals("AGOSTO") == false & mes.Equals("SEPTIEMBRE") == false & mes.Equals("OCTUBRE") == false & mes.Equals("NOVIEMBRE") == false & mes.Equals("DICIEMBRE") == false);
            do
                {
                    do
                    {
                        c = 0;
                        Console.Write("Ingrese el año en el que nació: ");
                        año = Console.ReadLine().Trim();
                        for (int y = 0; y < año.Length; y++)
                        {
                            if (Char.IsNumber(año[y]) == false) c++;
                        }
                    } while (c > 0);
                Console.WriteLine();
                } while (Convert.ToInt32(año) < 0);
            do
                {
                    do
                    {
                        c = 0;
                        Console.Write("Ingrese su sexo con mayúsculas (por ejemplo: MUJER): ");
                        sexo = Console.ReadLine().Trim();
                        sexo = sexo.ToUpper();
                        for (int t = 0; t < sexo.Length; t++)
                        {
                            if (Char.IsLetter(sexo[t]) == false)
                                c++;
                        }
                    } while (c > 0);
                Console.WriteLine();
                } while (sexo.Equals("MUJER") == false & sexo.Equals("HOMBRE") == false);
            do
            {
                do
                {
                    c = 0;
                    Console.Write("Ingrese el estado donde nació (por ejemplo: Chiapas): ");
                    lugar = Console.ReadLine().Trim();
                    lugar = lugar.ToUpper();
                    for (int t = 0; t < lugar.Length; t++)
                    { 
                        if (Char.IsLetter(lugar[t]) == false) c++;
                        if (Char.IsWhiteSpace(lugar[t]) == true) c--;
                    }
                } while (c > 0);
                Console.WriteLine();
            } while (lugar.Equals("AGUASCALIENTES") == false & lugar.Equals("BAJA CALIFORNIA") == false & lugar.Equals("BAJA CALIFORNIA SUR") == false & lugar.Equals("CAMPECHE") == false & lugar.Equals("COAHULIA") == false & lugar.Equals("COLIMA") == false & lugar.Equals("CHIAPAS") == false & lugar.Equals("CHIHUAHUA") == false & lugar.Equals("DISTRITO FEDERAL") == false & lugar.Equals("DURANGO") == false & lugar.Equals("GUANAJUATO") == false & lugar.Equals("GUERRERO") == false & lugar.Equals("HIDALGO") == false & lugar.Equals("JALISCO") == false & lugar.Equals("MEXICO") == false & lugar.Equals("MICHOACAN") == false & lugar.Equals("MORELOS") == false & lugar.Equals("NAYARIT") == false & lugar.Equals("NUEVO LEON") == false & lugar.Equals("OAXACA") == false & lugar.Equals("PUEBLA") == false & lugar.Equals("QUERETARO") == false & lugar.Equals("QUINTANA ROO") == false & lugar.Equals("SAN LUIS POTOSI") == false & lugar.Equals("SINALOA") == false & lugar.Equals("SONORA") == false & lugar.Equals("TABASCO") == false & lugar.Equals("TAMAULIPAS") == false & lugar.Equals("TLAXCALA") == false & lugar.Equals("VERACRUZ") == false & lugar.Equals("YUCATAN") == false & lugar.Equals("ZACATECAS") == false & lugar.Equals("CIUDAD DE MEXICO")==false);
            string nc = ap + " " + am + " " + nombre;
            parteUnoyDos Uno = new parteUnoyDos(nombre,ap,am);
            sexo Dos = new sexo(sexo);
            estado Tres = new estado(lugar);
            parteTres uno = new parteTres(nombre, ap, am);
            Homoclave h = new Homoclave(nc);
            Uno.setAño(Convert.ToInt32(año));
            Uno.setDia(Convert.ToInt32(dia));
            Uno.setMes(mes);

            string bueno = Uno.getApellidop() + Uno.getApellidom() + Uno.getNombre() + Uno.getAño() + Uno.getMes() + Uno.getDia() + Dos.getSexo() + Tres.getEstado() + uno.getApellidop() + uno.getApellidom() + uno.getNombre();
            string tmp = Uno.getApellidop() + Uno.getApellidom() + Uno.getNombre() + Uno.getAño() + Uno.getMes() + Uno.getDia() + h.getNombre();
            digito dos = new digito(tmp);
            diferencia k = new diferencia(año);

            Console.WriteLine("\nHere you go! El proceso se ha terminado.\n");
            Console.WriteLine(bueno + k.getNumero() + dos.getDigito() + "\n");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey(true);
            }
        }
    }
