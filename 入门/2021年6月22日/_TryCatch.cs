namespace 入门._2021年6月22日
{
    class _TryCatch
    {
        static string[] eTypes = { "none", "simple", "index", "nested index", "filter" };
        public static void TestTryCatch()
        {
            foreach (string eType in eTypes)
            {
                try
                {
                    System.Console.WriteLine("Main() try block reached.");
                    System.Console.WriteLine($"ThrowExeception(\"{eType}\") called.");
                    ThrowException(eType);
                    System.Console.WriteLine("Main() block continues.");
                }
                catch (System.IndexOutOfRangeException e) when (eType == "filter")
                {
                    System.Console.WriteLine("Main() FILTERED System.IndexOutRangeException" + $"catch block reached.Message:\n\"{e.Message}\"");
                }
                catch (System.IndexOutOfRangeException e)
                {
                    System.Console.WriteLine("Main() System.IndexoutOfRangeException catch " + $"block reached. Message:\n \" {e.Message} \"");
                }
                catch
                {
                    System.Console.WriteLine("Main() general catch block reached.");
                }
                finally
                {
                    System.Console.WriteLine("Main() finally block reached.");
                }
                System.Console.WriteLine();
            }
        }
        static void ThrowException(string exceptionType)
        {
            System.Console.WriteLine($"ThrowException(\"{exceptionType}\") reached.");
            switch (exceptionType)
            {
                case "none":
                    System.Console.WriteLine("Not throwing an exception.");
                    break;
                case "simple":
                    System.Console.WriteLine("Throwing System.Exception.");
                    break;
                case "index":
                    System.Console.WriteLine("Throwing System.IndexOutOfRangeException.");
                    eTypes[5] = "error";
                    break;
                case "nested index":
                    try
                    {
                        System.Console.WriteLine("ThrowException(\"nested index\")" + "try block reached.");
                        System.Console.WriteLine("ThrowException(\"index\") called.");
                        ThrowException("index");
                    }
                    catch
                    {
                        System.Console.WriteLine("ThrowException(\"nested index\") geberal" + "catch block reached.");
                    }
                    finally
                    {
                        System.Console.WriteLine("ThrowException(\"nested index\") finally" + "block reached.");
                    }
                    break;
                case "filter":
                    try
                    {
                        System.Console.WriteLine("ThrowException(\"filter\")." + "try block reached.");
                        System.Console.WriteLine("ThrowException(\"index\") called.");
                        ThrowException("index");
                    }
                    catch
                    {
                        System.Console.WriteLine("ThrowException(\"filter\") general" + "catch block reached.");
                        throw;
                    }
                    break;
            }
        }
    }
}