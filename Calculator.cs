class Calculator
{
	static void main(string[] args)
	{
		int a = 10;
		int b = 6;
		
		console.WriteLine("Hasli penjumlahan : {0} + {1} = {2}", a, b, Penambahan(a, b));
		console.WriteLine("Hasli pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
		
		console.WriteLine("\nTekan sembarang key untuk keluar");
		console.Readkey();
	}
	
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	
	static int Pengurangan(int a, int b)
	{
		return a - b;
}