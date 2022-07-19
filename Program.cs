using System;

namespace objected_oriented_programming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var word = new ACoder("hello");
            word.Decode();
            word.Encode();
            string word_1 = word.Text;
            word.Decode();
            string word_2 = word.Text;
            

            var sent = new BCoder("AAA");
            sent.Encode();
            string sen_1 = sent.Text;
            sent.Decode();
            string sen_2 = sent.Text;

            var sentence = new BCoder("bbb");
            sentence.Encode();
            string sentence_1 = sentence.Text;
            sentence.Decode();
            string sentence_2 = sentence.Text;
        }
    }
}
