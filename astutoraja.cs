using system

class program {
    static void Main (){
        int total = 64:
        int granos = 1;
        console.writeline("Casillas | Granos en las casillas");
        for (int i=1 ; i= total; i++){
            console.writeline($"{i}  |{granos}");
            granos *= 2;
        }

    }
}