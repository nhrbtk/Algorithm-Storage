﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using algStorage.DAL.Repositories;
using algStorage.DAL.Entities;
using System.IO;

namespace algStorage.BLL
{
    public class AlgorithmOperation
    {
        private static string startPath = @"D:\algStorage\Storage\";
        private AlgorithmRepository algorithmRepository;
        public AlgorithmOperation()
        {
            algorithmRepository = new AlgorithmRepository();
        }

        public IEnumerable<Algorithm> GetUserAlgoritms(int userId)
        {
            return algorithmRepository.GetAll().Where(u => u.UserId == userId);
        }

        public int GetAlgorithmID(int userId, string title)
        {
            try
            {
                return algorithmRepository.GetAll().Where(a => a.UserId == userId).Single(a => a.Title == title).Id;
            }
            catch(Exception)
            {
                return -1;
            }
        }

        public List<string> GetUserAlgorithmTitles(int id)
        {
            try
            {
                var list = algorithmRepository.GetAll().Where(a => a.UserId == id);
                List<string> result = new List<string>();
                foreach (var l in list)
                    result.Add(l.Title);
                return result;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool TitleExists(int userId, string title)
        {
            return algorithmRepository.GetAll().Where(a=>a.UserId==userId).Any(a => a.Title == title);
        }

        public bool AddAlgorithm(int userId, string title, string code, string input, string output)
        {
            try
            {
                string codePath = startPath + userId + $@"\{title}.code";
                string inputPath = startPath + userId + $@"\{title}.in";
                string outputPath = startPath + userId + $@"\{title}.out";

                if (!Directory.Exists(startPath + userId + @"\"))
                {
                    Directory.CreateDirectory(startPath + userId + @"\");
                }

                WriteToFile(codePath, code);
                WriteToFile(inputPath, input);
                WriteToFile(outputPath, output);
                if (!TitleExists(userId, title))
                {
                    algorithmRepository.Create(new Algorithm { UserId = userId, Title = title, Path = codePath, Input = inputPath, Output = outputPath });
                    algorithmRepository.Save();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string GetAlgoritmCode(int id)
        {
            try
            {
                string path = algorithmRepository.GetAll().Single(a => a.Id == id).Path;
                return File.ReadAllText(path, Encoding.Unicode);
            }
            catch(Exception)
            {
                return null;
            }
        }

        public string GetAlgoritmInput(int id)
        {
            try
            {
                string path = algorithmRepository.GetAll().Single(a => a.Id == id).Input;
                return File.ReadAllText(path, Encoding.Unicode);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string GetAlgoritmOutput(int id)
        {
            try
            {
                string path = algorithmRepository.GetAll().Single(a => a.Id == id).Output;
                return File.ReadAllText(path, Encoding.Unicode);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<string> GetTitles(int userId)
        {
            List<string> returnList=new List<string>();
            var list = algorithmRepository.GetAll().Where(a => a.UserId == userId);
            foreach (var l in list)
            {
                returnList.Add(l.Title);
            }
            return returnList;
        }

        public bool DeleteAlgorithm(int id)
        {
            try
            {
                var alg = algorithmRepository.Read(id);
                File.Delete(alg.Path);
                File.Delete(alg.Input);
                File.Delete(alg.Output);
                //Directory.Delete(Path.GetDirectoryName(alg.Path));
                algorithmRepository.Delete(id);
                algorithmRepository.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteDirectory(int userId)
        {
            try
            {
                string p = startPath + userId +@"\";
                Directory.Delete(p);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public List<int> GetAlgorithmsAuthors(List<int> algorithmIds)
        {
            try
            {
                List<int> result = new List<int>();
                foreach(var a in algorithmIds)
                {
                    result.Add(algorithmRepository.Read(a).UserId);
                }
            }
            catch (Exception)
            {
                return null;
            }

        }


        private void WriteToFile(string pathToFile, string content)
        {
            File.WriteAllText(pathToFile, content, Encoding.Unicode);
        }
    }
}
