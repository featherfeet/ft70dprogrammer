Programmer.exe: *.cs Decompiled/*.cs
	mcs /reference:System.Net.Http.dll *.cs Decompiled/*.cs
run: Programmer.exe
	chmod +x Programmer.exe
	./Programmer.exe CLNFTM400D.dat Repeaters.csv CLNFTM400D.dat.new
