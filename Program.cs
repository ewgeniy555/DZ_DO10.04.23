        string a="";
		string str= "Привет как дела у вас всё хорошо?  ";
		string[]ar = new string[str.Length/3];
        int index =0;
		for(int i =0;i<str.Length/3;i++){	
		 for(int j=0;j<3;j++){
			a=a.Insert(j,str[index].ToString());//заталкивае символы по одному
           ar[i]=a;
           if(index>=str.Length-1){index=0;j=3;} //останвливает цикл если символов не хватает в конце
            index++;	
		 }
        a="";//очищает строку
		// Console.WriteLine(ar[i]);
		}
	
