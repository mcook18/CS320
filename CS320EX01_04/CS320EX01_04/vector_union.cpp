#include"iostream"
#include"vector"
using namespace std;

vector<int>& unionVectors(vector<int>& a, vector<int>& b);
vector <int> Union;
int main(){
	vector<int>a;
	vector<int>b;

	cout << "Please give me 10 integers for vector a: " << endl;
	


}
vector<int>& unionVectors(vector<int>& a, vector<int>& b){
	int count = 0;
	
	do {
		if (a[count] == b[count]){
			Union[count] = a[count];
			count++;
		}
		else{
			Union[count] = a[count];
			Union[count + 1] = b[count];
			count + 2;
		}
		
	} while (count <= (sizeof a) + (sizeof b));
	return (Union);

}

