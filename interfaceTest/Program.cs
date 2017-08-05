using System;
using System.Text;

namespace interfaceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Console.WriteLine("Hello World!");
            Console.WriteLine("こんちわ！");

            IPlug monitorA = new Monitor();
            IPlug keybordA = new Keybord();

            //こちらはstaticが不要。
            void Connected(IPlug device)
            {
                Console.WriteLine($"{device}が接続されました！");
            }

            Connected(monitorA);
            Connected(keybordA);

            Console.ReadLine();
        }

        //static void Connected(IPlug device)
        //{
        //    Console.WriteLine($"{device}が接続されました！");
        //}

        // 問題点。出力にnamespaceが入る。なので、classにpropertyを設定すべきかも。

        // 参照。以下。
        // (151) 【プログラミング講座（C#）】第10回 インターフェースについて【独り言】 - YouTube https://www.youtube.com/watch?v=U4FhAs3hveo
        // Visual Studioで一括コメントアウトするショートカットキー - 大人になったら肺呼吸 http://d.hatena.ne.jp/replication/20140207/1392391422
        // [C# 6.0] nameof 演算子で引数名などを文字列として取得できる (ArgumentExceptionとかで楽) | 学習B5デスノート http://fernweh.jp/b/csharp-nameof-operator/
        // ある型の値を別の型に変換（キャスト）する: .NET Tips: C#, VB.NET https://dobon.net/vb/dotnet/beginner/cast.html
        // C#超・初心者が知っておくべき10のエラー http://shirakamisauto.hatenablog.com/entry/2016/01/26/153715
    }
}