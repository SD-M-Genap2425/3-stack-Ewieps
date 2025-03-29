using System;

    namespace Solution.BrowserHistory;

        public class Halaman
        {
            public string URL {get; private set;}
            public Halaman(string url)
            {
                URL = url;
            }
        }

        public class BrowserNode
        {
            public Halaman Data {get; set;}
            public BrowserNode Next {get; set;}
            public BrowserNode(Halaman data)
            {
                Data = data; 
                Next = null;
            }
        }

        public class HistoryManager
        {
            private BrowserNode top;

            public HistoryManager()
            {
                this.top = null;
            }

            public void KunjungiHalaman(string url)
            {
                BrowserNode newBNode = new BrowserNode(new Halaman(url));
                newBNode.Next = top;
                top = newBNode;
                Console.WriteLine($"Mengunjungi halaman: {url}");
            }

            public string Kembali()
            {
                if (top == null || top.Next == null)
                {
                    Console.WriteLine("Tidak ada halaman sebelumnya.");
                    return "Tidak ada halaman sebelumnya.";
                    }

                top =top.Next;
                Console.WriteLine("Kembali ke halaman sebelumnya...");
                return top.Data.URL;
            }

            public string LihatHalamanSaatIni()
            {
                return top != null ? top.Data.URL : "History kosong";
            }

            public void TampilkanHistory()
            {
                if (top == null)
                {
                    Console.WriteLine("History kosong.");
                    return;
                }

                Stack<string> reversedHistory = new Stack<string>();
                BrowserNode temp = top;

                while (temp != null)
                {
                    reversedHistory.Push(temp.Data.URL);
                    temp = temp.Next;
                }

                foreach (var page in reversedHistory)
                {
                    Console.WriteLine(page);
                }
            }
        }