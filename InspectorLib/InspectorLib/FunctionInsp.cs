using System;
using System.Collections.Generic;
using System.Linq;

namespace InspectorLib
{
    public class FunctionInsp
    {
        // Поле для хранения имени главного инспектора
        private string _mainInspector = "Васильев Василий Иванович";

        // Поле для хранения названия автоинспекции
        private string _carInspection = "Автоинспекция г. Чита";

        // Список сотрудников автоинспекции
        private List<string> _workers = new List<string>
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        // Метод для получения имени главного инспектора
        public string GetInspector()
        {
            return _mainInspector;
        }

        // Метод для получения названия автоинспекции
        public string GetCarInspection()
        {
            return _carInspection;
        }

        // Метод для изменения имени главного инспектора, если оно есть в списке сотрудников
        public bool SetInspector(string fullname)
        {
            if (_workers.Contains(fullname))
            {
                _mainInspector = fullname;
                return true;
            }
            return false;
        }

        // Метод для генерации госномера
        public string GenerateNumber()
        {
            Random rand = new Random(); int number = rand.Next(100, 1000);
            // Генерация случайного числа от 100 до 999
            string symbols = "АВЕКМНОРСТУХ"; 
            // Доступные символы кириллицы
            char firstSymbol = symbols[rand.Next(symbols.Length)];
            return $"{firstSymbol}{number}_75"; 
        }
        // Метод для получения списка сотрудников
        public List<string> GetWorker() 
        { 
            return _workers;
        }

            // Метод для добавления нового сотрудника в список
            public void AddWorker(string fullname)
        {
            if (!_workers.Contains(fullname))
            {
                _workers.Add(fullname);
            }
        }
    }
}
