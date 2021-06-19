using MySCADA;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MySCADA_Xamarin
{
    public class AlarmTagVM : INotifyPropertyChanged
    {
        private ObservableCollection<AlarmTag> alarmTags;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<AlarmTag> AlarmTags
        {
            get { return alarmTags; }
            set
            {
                alarmTags = value;
            }
        }

        public AlarmTagVM(List<AlarmTag> alarmTagsList)
        {
            // Here you can have your data form db or something else,
            // some data that you already have to put in the list
            AlarmTags = new ObservableCollection<AlarmTag>();
            foreach (var item in alarmTagsList)
            {
                AlarmTags.Add(item);
            }
        }

        //public void AddAlarmTag(AlarmTag alarmtag)
        //{
        //    AlarmTags.Add(alarmtag);
        //}
    }
}