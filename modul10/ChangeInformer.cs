using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul10
{
    class ChangeInformer
    {
        public ChangeInformer() 
        {
            ChangedData = new Dictionary<string, string>();
        }
        DateTime ChangeTime { get; set; }
        WorkerPosition ChangerPosition { get; set; }

        Dictionary<string, string> ChangedData { get; set; }

        public void SaveChange(WorkerPosition workerPosition, string changeData, string newData)
        {
            ChangeTime = DateTime.Now;
            ChangerPosition = workerPosition;
            ChangedData.Add(changeData, newData);
        }

        public string GetChangeInfo()
        {
            string changedData = string.Empty;
            foreach (var item in ChangedData)
            {
                changedData += $"Было:{item.Key} Стало: {item.Value}\n";
            }
            return $"\nПоследний изменил данные: {ChangerPosition}\n" +
                $"Последние измения: {ChangeTime}\n" +
                changedData;
        }
    }
}
