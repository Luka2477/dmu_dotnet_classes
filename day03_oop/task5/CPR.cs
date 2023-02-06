using System;
namespace task5
{
	public class CPR
	{
		public string BirthDate { get; private set; }
		public string SequenceNumber { get; private set; }

		public CPR(string birthDate, string sequenceNumber)
			=> (BirthDate, SequenceNumber) = (birthDate, sequenceNumber);

        public override string ToString()
        {
			return $"{BirthDate}-{SequenceNumber}";
        }
    }
}

