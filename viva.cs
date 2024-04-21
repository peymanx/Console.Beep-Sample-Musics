 public static void HappyBirthDay()
 {
    // diid--di-di--diid-diid--diiiid

    var did = 90;
    var diid = did * 2;
    var diiiid = did * 4;

    var freq = 300;

    Console.Beep(freq, diid);
    Thread.Sleep(diid);

    Console.Beep(freq, did);
    Thread.Sleep(did);
    Console.Beep(freq, did);
    Thread.Sleep(diid);

    Console.Beep(freq, diid);
    Thread.Sleep(did);
    Console.Beep(freq, diid);
    Thread.Sleep(did);

    Console.Beep(freq, diiiid);
    Thread.Sleep(diiiid);


    Console.ReadKey();
 }
