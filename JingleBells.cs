// Christmas Songs – Jingle Bells
// Jingle bells, jingle bells
// Jingle all the way

        public static void JingleBells()
        {
            var C4 = 261;
            var C5 = 523;
            var D4 = 293;
            var D5 = 587;
            var E4 = 329;
            var E5 = 659;
            var F5 = 698;
            var G5 = 784;

            Console.Beep(E5, 250);
            Console.Beep(E5, 250);
            Console.Beep(E5, 250);

            Thread.Sleep(350);

            Console.Beep(E5, 250);
            Console.Beep(E5, 250);
            Console.Beep(E5, 250);

            Thread.Sleep(350);

            Console.Beep(E5, 250);
            Console.Beep(G5, 250);
            Console.Beep(C5, 250);
            Console.Beep(D5, 250);
            Console.Beep(E5, 250);

            Console.Beep(C4, 250);
            Console.Beep(D4, 250);
            Console.Beep(E4, 250);

            Console.Beep(F5, 250);
            Console.Beep(F5, 250);
            Console.Beep(F5, 250);

            Thread.Sleep(350);

            Console.Beep(F5, 250);
            Console.Beep(E5, 250);
            Console.Beep(E5, 250);

            Thread.Sleep(350);

            Console.Beep(E5, 250);
            Console.Beep(D5, 250);
            Console.Beep(D5, 250);
            Console.Beep(E5, 250);
            Console.Beep(D5, 250);

            Thread.Sleep(350);
        }
