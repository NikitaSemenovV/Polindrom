namespace ConsoleApp1
{
    class Program
    /// <summary>
    /// Программа сравнивает каждый новый символ строки с сиволами после него последовательно
    /// Если выпадает схожий символ то сравниваем наш символ со следующим по последовательности если нет то добавляем следующий символ в строку
    /// и начинаем сравнивать со следующими
    /// </summary>
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader Fileln =
            new System.IO.StreamReader(@"C:\Users\Никита\Desktop\input.txt");
            /// <param name=Fileln>запись из файла ввода input.txt</param>
            string strIn = Fileln.ReadLine();
            /// <param name = "">хранит значение пустоты</param>
            string strRez = "";
            /// <param name=>хранит результат выполнения программы</param>
            string result;
            /// <param name = strIn[0]>хранит значение нулевого в строке элемента</ param >
            char c = strIn[0];
            /// <param name = c>хранит последовательность из элементов и количества их повторений </ param >
            strRez += c;
            /// <param name=1>хранит количество повторений элемента</param>
            int len = 1;
            /// <summary>
            /// цикл for для сравнения элемента с последующими
            /// else для перехода на след элемент при несвопадении и продолжения последовтельности из символов и их количества
            /// strRez для записи колиечства последнего элемента строки
            /// </summary>
            for (int i = 1; i < strIn.Length; i++)
                if (strIn[i] < 'a' || strIn[i] > 'z' || strIn[i] < 'а' || strIn[i] < 'я')
                {
                    File.WriteAllText("output.txt", "Ошибка, пишете плохо не по ТЗ!!!");
                    return;
                }
            if (c == strIn[i])
                len++;
            else
            {
                c = strIn[i];
                strRez += string.Format("{0}{1}", len, c);
                len = 1;
            }
            strRez += string.Format("{0}", len);
            Fileln.Close();
            ///<returns>
            ///Возвращает строку из символов и их повторений
            ///</returns>
            System.IO.StreamWriter Fileout =
            new System.IO.StreamWriter(@"C:\Users\Никита\Desktop\output.txt");
            result = strRez.Replace("1", "");
            Fileout.WriteLine(result);
            Fileout.Close();
        }
    }
}