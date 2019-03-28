long Fatorial(int n)
    {
       
        if (n > 1)
        {

            return n * Fatorial(n - 1); 
            
        }
        else if(n<0)
        {
        print("não existe fatorial de número negativo");
        }
        else
        {
            return 1;
        }
        
    }
