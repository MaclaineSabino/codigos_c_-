void resultado_pesquisa()
    {
        //0 - não
        //1 - sim

        int total_sim = 0;
        int total_nao = 0;

        for(int i = 1; i <= 500; i++)
        {
            System.Random rando = new System.Random();
            int resposta = rando.Next(0, 2);
            print(resposta);
            if (resposta == 1)
            {
                total_sim++;
            }
            else
            {
                total_nao++;
            }

        }

        print("total de sim foi: " + total_sim);
        print("total de não foi: " + total_nao);
    }
