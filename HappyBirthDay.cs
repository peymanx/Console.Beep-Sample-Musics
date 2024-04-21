 public static void HappyBirthDay()
 {
     int C = 264;
     int D = 297;
     int E = 330;
     int F = 352;
     int G = 396;
     int A = 440;
     int Bb = 466;
     int B = 495;
     int C2 = 528;

     int note = 1000;
     int half = 1000 / 2;
     int quarter = 1000 / 4;
     int eighth = 1000 / 6;

     Console.Beep(C, eighth);
     Thread.Sleep(quarter);
     Console.Beep(C, eighth);
     Thread.Sleep(eighth);
     Console.Beep(D, half);
     Thread.Sleep(eighth);
     Console.Beep(C, half);
     Thread.Sleep(eighth);
     Console.Beep(F, half);
     Thread.Sleep(eighth);
     Console.Beep(E, note);
     Thread.Sleep(quarter);

     Console.Beep(C, eighth);
     Thread.Sleep(quarter);
     Console.Beep(C, eighth);
     Thread.Sleep(eighth);
     Console.Beep(D, half);
     Thread.Sleep(eighth);
     Console.Beep(C, half);
     Thread.Sleep(eighth);
     Console.Beep(G, half);
     Thread.Sleep(eighth);
     Console.Beep(F, note);

     Thread.Sleep(quarter);
     Console.Beep(C, eighth);
     Thread.Sleep(quarter);
     Console.Beep(C, eighth);
     Thread.Sleep(eighth);
     Console.Beep(C2, half);
     Thread.Sleep(eighth);
     Console.Beep(A, half);
     Thread.Sleep(eighth);
     Console.Beep(F, quarter);
     Thread.Sleep(eighth);
     Console.Beep(F, eighth);
     Thread.Sleep(eighth);
     Console.Beep(E, half);
     Thread.Sleep(eighth);
     Console.Beep(D, note);

     Thread.Sleep(quarter);
     Console.Beep(Bb, eighth);
     Thread.Sleep(quarter);
     Console.Beep(Bb, eighth);
     Thread.Sleep(eighth);
     Console.Beep(A, half);
     Thread.Sleep(eighth);
     Console.Beep(F, half);
     Thread.Sleep(eighth);
     Console.Beep(G, half);
     Thread.Sleep(eighth);
     Console.Beep(F, note);

 }
