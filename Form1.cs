using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static tudien11.Form1;

namespace tudien11
{
    public partial class Form1 : Form
    {
        public class Word
        {
            public string Term { get; set; }
            public string Type { get; set; }
            public List<string> Meanings { get; set; }
            public List<string> Examples { get; set; }
            public Word Previous { get; set; }
            public Word Next { get; set; }

            public Word(string term, string type, List<string> meanings, List<string> examples)
            {
                Term = term;
                Type = type;
                Meanings = meanings;
                Examples = examples;
                Previous = null;
                Next = null;

            }
            public override string ToString()
            {
                return Term;
            }
        }
        public class Dictionary
        {
           
            private Word firstWord;
            private Word lastWord;
            private List<Word>[] hashArray;

            public Dictionary()
            {
                InitializeDictionary();
            }

            public void InitializeDictionary()
            {
                firstWord = null;
                lastWord = null;
                hashArray = new List<Word>[26];
                for (int i = 0; i < 26; i++)
                {
                    hashArray[i] = new List<Word>();
                }

                LoadDictionaryFromFile("dictionary.txt");
            }

            public void AddWord(string term, string type, List<string> meanings, List<string> examples)
            {
                Word newWord = new Word(term, type, meanings, examples);
                AddWordToList(newWord);
                AddWordToHashTable(newWord);
            }

            public void AddWordToList(Word word)
            {
                if (firstWord == null)
                {
                    // Adding the first word
                    firstWord = word;
                    lastWord = word;
                }
                else
                {
                    // Adding subsequent words
                    lastWord.Next = word;
                    word.Previous = lastWord;
                    lastWord = word;
                }
            }

            public void AddWordToHashTable(Word word)
            {
                int index = GetHashIndex(word.Term[0]);
                hashArray[index].Add(word);
            }

            public int GetHashIndex(char c)
            {
                return char.ToUpper(c) - 'A';
            }

            public Word SearchWord(string term)
            {
                int index = GetHashIndex(term[0]);
                List<Word> words = hashArray[index];
                foreach (Word word in words)
                {
                    if (word.Term.Equals(term, StringComparison.OrdinalIgnoreCase))
                    {
                        return word;
                    }
                }
                return null;
            }

            public void EditWord(Word word, string newType, List<string> newMeanings, List<string> newExamples)
            {
                if (!string.IsNullOrEmpty(newType))
                {
                    word.Type = newType;
                }

                if (newMeanings.Count > 0)
                {
                    word.Meanings = newMeanings;
                }

                if (newExamples.Count > 0)
                {
                    word.Examples = newExamples;
                }
               
            }

            public void DeleteWord(Word word)
            {
                if (word == firstWord)
                {
                    // Deleting the first word
                    firstWord = word.Next;
                    if (firstWord != null)
                    {
                        firstWord.Previous = null;
                    }
                }
                else if (word == lastWord)
                {
                    // Deleting the last word
                    lastWord = word.Previous;
                    if (lastWord != null)
                    {
                        lastWord.Next = null;
                    }
                }
                else
                {
                    // Deleting a word in the middle
                    word.Previous.Next = word.Next;
                    word.Next.Previous = word.Previous;
                }

                int index = GetHashIndex(word.Term[0]);
                hashArray[index].Remove(word);

                RemoveWordFromFile(word); // Xóa từ trong tệp
            }
            public void RemoveWordFromFile(Word word)
            {
                string fileName = "dictionary.txt";
                try
                {
                    string[] lines = File.ReadAllLines(fileName);
                    List<string> updatedLines = new List<string>();
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('|');
                        if (parts.Length == 4)
                        {
                            string term = parts[0];
                            if (!term.Equals(word.Term, StringComparison.OrdinalIgnoreCase))
                            {
                                updatedLines.Add(line);
                            }
                        }
                    }

                    File.WriteAllLines(fileName, updatedLines);
                }
                catch (IOException)
                {
                    MessageBox.Show("Error removing the word from the dictionary file.");
                }
            }


            public void SaveDictionaryToFile(string fileName)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(fileName))
                    {
                        Word currentWord = firstWord;
                        while (currentWord != null)
                        {
                            // Ghi thông tin từ vào tệp
                            sw.WriteLine($"{currentWord.Term}|{currentWord.Type}|{string.Join(";", currentWord.Meanings)}|{string.Join(";", currentWord.Examples)}");

                            currentWord = currentWord.Next;
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Error writing to the dictionary file.");
                }
            }

            public void LoadDictionaryFromFile(string fileName)
            {
                try
                {
                    if (!File.Exists(fileName))
                    {
                        // Tạo tệp mới nếu không tồn tại
                        File.Create(fileName).Close();
                        return;
                    }

                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] parts = line.Split('|');
                            if (parts.Length == 4)
                            {
                                string term = parts[0];
                                string type = parts[1];
                                List<string> meanings = new List<string>(parts[2].Split(';'));
                                List<string> examples = new List<string>(parts[3].Split(';'));

                                AddWord(term, type, meanings, examples);
                            }
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Error reading the dictionary file.");
                }
            }
        



    }
        private Dictionary dictionary;

        public Form1()
        {
            InitializeComponent();
            dictionary = new Dictionary();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            string term = txtTerm.Text.Trim();
            string type = txtType.Text.Trim();
            string[] meanings = txtMeanings.Text.Trim().Split(';');
            string[] examples = txtExamples.Text.Trim().Split(';');

            if (!string.IsNullOrEmpty(term) && !string.IsNullOrEmpty(type))
            {
                // Kiểm tra xem từ đã tồn tại trong từ điển hay chưa
                Word existingWord = dictionary.SearchWord(term);
                if (existingWord != null)
                {
                    MessageBox.Show("Từ đã tồn tại trong từ điển.");
                    ClearFields(); // Xóa nội dung các trường văn bản
                    return;
                }

                List<string> meaningList = new List<string>(meanings);
                List<string> exampleList = new List<string>(examples);

                dictionary.AddWord(term, type, meaningList, exampleList);
                ClearFields();
                MessageBox.Show("Từ đã được thêm thành công.");

                // Lưu từ điển vào tệp
                dictionary.SaveDictionaryToFile("dictionary.txt");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin từ và loại từ.");
            }
        }

        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            string term = txtSearchTerm.Text;
            Word word = dictionary.SearchWord(term);

            if (!string.IsNullOrEmpty(term))
            {
                if (word != null)
                {
                    // Hiển thị thông tin từ tìm kiếm
                    txtTerm.Text = word.Term;
                    txtType.Text = word.Type;

                    // Hiển thị nghĩa
                    txtMeanings.Text = string.Join("; ", word.Meanings);

                    // Hiển thị ví dụ
                    txtExamples.Text = string.Join("; ", word.Examples);
                }
                else
                {
                    MessageBox.Show("Từ không tồn tại trong từ điển.");
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ cần tra.");
            }
            txtSearchTerm.Focus();
            txtSearchTerm.Clear();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            string term = txtTerm.Text.Trim();

            Word word = dictionary.SearchWord(term);
            if (word == null)
            {
                MessageBox.Show("Từ không tồn tại.");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa từ này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                dictionary.DeleteWord(word);
                ClearFields();
                MessageBox.Show("Từ đã được xóa thành công.");
            }
        }
        public void ClearFields()
        {
            txtTerm.Text = string.Empty;
            txtType.Text = string.Empty;
            txtMeanings.Text = string.Empty;
            txtExamples.Text = string.Empty;
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            string term = txtTerm.Text.Trim();
            string type = txtType.Text.Trim();
            string[] meanings = txtMeanings.Text.Trim().Split(';');
            string[] examples = txtExamples.Text.Trim().Split(';');

            if (!string.IsNullOrEmpty(term))
            {
                Word word = dictionary.SearchWord(term);

                if (word != null)
                {
                    // Chỉnh sửa thông tin từ
                    dictionary.EditWord(word, type, new List<string>(meanings), new List<string>(examples));
                    MessageBox.Show("Từ đã được chỉnh sửa thành công.");

                    // Xóa nội dung các trường văn bản
                 
                    ClearFields();
                    dictionary.SaveDictionaryToFile("dictionary.txt");
                }
                else
                {
                    MessageBox.Show("Từ không tồn tại trong từ điển.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ cần chỉnh sửa.");
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSearchTerm_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

