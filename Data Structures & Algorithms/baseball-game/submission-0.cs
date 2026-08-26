public class Solution {
    public int CalPoints(string[] operations) {
        List<int> record = new List<int>();

        for(int i=0;i< operations.Length;i++){
            if(int.TryParse(operations[i], out int num)){
                record.Add(num);
            }
            else
            {
                switch(operations[i]){
                    case "+":
                        int sum = record[record.Count - 1] + record[record.Count - 2];
                        record.Add(sum);
                        break;
                    case "D":
                        int mul = record[record.Count - 1] * 2;
                        record.Add(mul);
                        break;
                    case "C":
                        record.RemoveAt(record.Count - 1);
                        break;
                }

            }
        }
        int total=0;
        foreach(int i in record){
            total += i;
        }
        return total;
    }
}