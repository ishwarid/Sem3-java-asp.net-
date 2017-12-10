/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package candy;

import java.util.Random;
import javax.swing.JLabel;
import javax.swing.JOptionPane;

/**
 *
 * @author Ishwari
 */
 abstract public class game extends javax.swing.JFrame {
     final int [][] arr1;
     final int [][] arr;
     final JLabel[][] img;
     int flag = 0;
     int flagblast =0;
      int score =0;
     static int time =0;
      int moves = 0;
      int score1 = 0;
     static int i1 = -1;
     static int i2 = -1;
     static int j1 = -1;
     static int j2 = -1;
     Random rnd = new Random();
     game()
     {
           arr1 = new int [8][8];
           arr = new int [8][8];
           img = new JLabel[8][8];
           
           
     }
     
     public abstract int CheckAll();
     public abstract void Down_Blast(int i , int j);
     public abstract void Right_Blast(int i , int j);
     public abstract void Down_Slide(int i,int j);
     public abstract void Right_Slide(int i,int j);
         
     public void arr_copy()
        {
            for (int c = 0; c <= 7; c++)
            {
                for (int d = 0; d <= 7; d++)
                {
                    arr[c][d] = arr1[c][d];
                }
            }
            System.out.println(" blast happnd");
        }
        public void arrcopy_rev()
        {
            for (int e = 0; e <= 7; e++)
            {
                for (int f = 0; f <= 7; f++)
                {
                    arr1[e][f] = arr[e][f];
                }
            }
        }
        
    public void setimgall()
    {
        int x;
        for (int a = 0; a <= 7; a++)
        {
            for (int b = 0; b <= 7; b++)
            {
                x = arr[a][b];
                if(x==0)
                    img[a][b].setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/c0.png")));
                if(x==1)
                    img[a][b].setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/c1.png")));
                if(x==2)
                    img[a][b].setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/c2.png")));
                if(x==3)
                    img[a][b].setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/c3.jpg")));
                if(x==4)
                    img[a][b].setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/c4.jpg")));
                if(x==5)
                    img[a][b].setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/c5.jpg")));
            }
        }
    }
    
            
      /* 
       public void Down_Blast(int i , int j)
       {
           System.out.println(" in DOWN BLAST FUNC()");
           score1 = score1 + ( arr[i][j] * 100 );
           /*
           arr1[i][j] = 0;
           arr1[i+1][j]=0;
           arr1[i+2][j]=0;
           //animation func
           Down_Slide(i ,j);
       } 
       * 
*/
    
       
              
      
       
}
