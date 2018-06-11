using System;
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
        private static string startPath = @"\algStorage\Storage\";
        private AlgorithmRepository algorithmRepository;
        public AlgorithmOperation()
        {
            algorithmRepository = new AlgorithmRepository();
        }

        public IEnumerable<Algorithm> GetUserAlgoritms(int userId)
        {
            return algorithmRepository.GetAll().Where(u => u.UserId == userId);
        }

        public IEnumerable<Algorithm> GetAllAlgorithms(bool role)
        {
            if (role)
                return algorithmRepository.GetAll();
            else
                return null;
        }



        public bool AddAlgorithm(int userId, string title, string code, string input, string output)
        {
            try
            {
                string codePath = startPath + userId + $@"\{title}.code";
                string inputPath = startPath + userId + $@"\{title}.in";
                string outputPath = startPath + userId + $@"\{title}.out";

                WriteToFile(codePath, code);
                WriteToFile(inputPath, input);
                WriteToFile(outputPath, output);

                algorithmRepository.Create(new Algorithm { UserId = userId, Title = title, Path = codePath, Input = inputPath, Output = outputPath });
                algorithmRepository.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void WriteToFile(string pathToFile, string content)
        {
            File.WriteAllText(pathToFile, content, Encoding.Unicode);
        }
    }
}
