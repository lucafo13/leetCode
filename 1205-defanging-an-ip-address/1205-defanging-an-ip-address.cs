public class Solution {
    public string DefangIPaddr(string address) {
        string newStr = "";
        for(int i = 0; i < address.Length; i++){
            if(address[i] == '.'){
                newStr += "[.]";
            } else {
                newStr += address[i];
            }
        }
        return newStr;
    }
}