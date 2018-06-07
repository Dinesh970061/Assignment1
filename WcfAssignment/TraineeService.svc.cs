using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfAssignment
{
    
    public class TraineeService : ITraineeService
    {
        public static List<Trainees> trainees = new List<Trainees>()
        {
            new Trainees {TraineeId=1,Name="Dinesh",Age=21,DOB=new DateTime(1996,11,20) },
            new Trainees {TraineeId=2,Name="Anamika",Age=20,DOB=new DateTime(1997,6,30) }
        };
        public List<Trainees> AddTraniee(Trainees addNewTrainee)
        {
            trainees.Add(addNewTrainee);
            return trainees;
        }
        public List<Trainees> DeleteTrainee(int deletedTraineeId)
        {
            var deletingTrainee = trainees.Find(t => t.TraineeId == deletedTraineeId);
            trainees.Remove(deletingTrainee);
            return trainees;
        }
        public List<Trainees> GetTrainee()
        {
            return trainees;
        }
        public List<Trainees> UpdateTrainee(Trainees updatedTrainee)
        {
            var deletingTrainee = trainees.Find(t => t.TraineeId == updatedTrainee.TraineeId);
            if (deletingTrainee == null)
                trainees.Add(updatedTrainee);
            else
            {
                trainees.Remove(deletingTrainee);
                trainees.Add(updatedTrainee);
            }
            return trainees;
            //throw new NotImplementedException();
        }
    }

}
