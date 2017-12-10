/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package candy;
import com.sun.xml.internal.ws.api.message.Message;
import java.util.Random;
import javax.swing.JLabel;
import java.util.Timer;
import java.util.*;
import javax.swing.JOptionPane;

/**
 *
 * @author Ishwari
 */
public class level1 extends   game{
    
  
    public level1() {
        
        super();
        
               initComponents();
               //assigning img in array.
            img[0][0] = pb00;
            img[0][1] = pb01;
            img[0][2] = pb02;
            img[0][3] = pb03;
            img[0][4] = pb04;
            img[0][5] = pb05;
            img[0][6] = pb06;
            img[0][7] = pb07;
            img[1][0] = pb10;
            img[1][1] = pb11;
            img[1][2] = pb12;
            img[1][3] = pb13;
            img[1][4] = pb14;
            img[1][5] = pb15;
            img[1][6] = pb16;
            img[1][7] = pb17;
            img[2][0] = pb20;
            img[2][1] = pb21;
            img[2][2] = pb22;
            img[2][3] = pb23;
            img[2][4] = pb24;
            img[2][5] = pb25;
            img[2][6] = pb26;
            img[2][7] = pb27;
            img[3][0] = pb30;
            img[3][1] = pb31;
            img[3][2] = pb32;
            img[3][3] = pb33;
            img[3][4] = pb34;
            img[3][5] = pb35;
            img[3][6] = pb36;
            img[3][7] = pb37;
            img[4][0] = pb40;
            img[4][1] = pb41;
            img[4][2] = pb42;
            img[4][3] = pb43;
            img[4][4] = pb44;
            img[4][5] = pb45;
            img[4][6] = pb46;
            img[4][7] = pb47;
            img[5][0] = pb50;
            img[5][1] = pb51;
            img[5][2] = pb52;
            img[5][3] = pb53;
            img[5][4] = pb54;
            img[5][5] = pb55;
            img[5][6] = pb56;
            img[5][7] = pb57;
            img[6][0] = pb60;
            img[6][1] = pb61;
            img[6][2] = pb62;
            img[6][3] = pb63;
            img[6][4] = pb64;
            img[6][5] = pb65;
            img[6][6] = pb66;
            img[6][7] = pb67;
            img[7][0] = pb70;
            img[7][1] = pb71;
            img[7][2] = pb72;
            img[7][3] = pb73;
            img[7][4] = pb74;
            img[7][5] = pb75;
            img[7][6] = pb76;
            img[7][7] = pb77;
            
           // giving value to img  
            arr[0][0] = 1;
            arr[0][1] = 2;
            arr[0][2] = 3;
            arr[0][3] = 4;
            arr[0][4] = 5;
            arr[0][5] = 1;
            arr[0][6] = 2;
            arr[0][7] = 5;
            arr[1][0] = 3;
            arr[1][1] = 2;
            arr[1][2] = 1;
            arr[1][3] = 5;
            arr[1][4] = 4;
            arr[1][5] = 2;
            arr[1][6] = 3;
            arr[1][7] = 1;
            arr[2][0] = 3;
            arr[2][1] = 4;
            arr[2][2] = 1;
            arr[2][3] = 5;
            arr[2][4] = 2;
            arr[2][5] = 4;
            arr[2][6] = 1;
            arr[2][7] = 4;
            arr[3][0] = 5;
            arr[3][1] = 4;
            arr[3][2] = 3;
            arr[3][3] = 2;
            arr[3][4] = 1;
            arr[3][5] = 5;
            arr[3][6] = 4;
            arr[3][7] = 3;
            arr[4][0] = 1;
            arr[4][1] = 2;
            arr[4][2] = 3;
            arr[4][3] = 4;
            arr[4][4] = 5;
            arr[4][5] = 1;
            arr[4][6] = 2;
            arr[4][7] = 4;
            arr[5][0] = 5;
            arr[5][1] = 1;
            arr[5][2] = 4;
            arr[5][3] = 2;
            arr[5][4] = 3;
            arr[5][5] = 4;
            arr[5][6] = 5;
            arr[5][7] = 1;
            arr[6][0] = 1;
            arr[6][1] = 2;
            arr[6][2] = 3;
            arr[6][3] = 4;
            arr[6][4] = 5;
            arr[6][5] = 5;
            arr[6][6] = 2;
            arr[6][7] = 2;
            arr[7][0] = 1;
            arr[7][1] = 2;
            arr[7][2] = 3;
            arr[7][3] = 4;
            arr[7][4] = 5;
            arr[7][5] = 1;
            arr[7][6] = 2;
            arr[7][7] = 5;
            setimgall();
            arrcopy_rev();
            
            lblscore.setText("Score : "+score);
            lblmoves.setText("Moves : " + moves);
            btnback.setText("Back");
            btnnext.setText("Next");
            //showlblarr();
//            countMoves();
            
    }
    
    
        @Override
    public int CheckAll() {
         int temp;
           temp = arr1[i1][j1];
           arr1[i1][j1] = arr1 [i2][j2];
           arr1[i2][j2] = temp;
           flagblast=0;
           for (int aa = 0; aa <= 5; aa++)
            {
                for (int bb = 0; bb <= 7; bb++)
                {
                    if( arr1[aa][bb] ==  arr1[aa+1][bb] && arr1[aa+1][bb] == arr1[aa+2][bb] )
                    {
                        System.out.println("blasting down : row "+aa +" col "+bb);
                        flagblast =1;
                        Down_Blast(aa , bb);
                        arr_copy();
                    }
                }
            }                
           for (int aaa = 0; aaa <=7; aaa++)
            {
                for (int bbb = 0; bbb <=5; bbb++)
                {
                    if(arr1[aaa][bbb]==arr1[aaa][bbb+1] && arr1[aaa][bbb+1] ==arr1[aaa][bbb+2])
                    {
                        System.out.println("blasting right : row "+aaa +" col "+bbb);
                        flagblast=1;
                        Right_Blast(aaa , bbb);
                        arr_copy();
                    }
                }
            }
           if(flagblast==0)
           {
               System.out.println("aaaaaaaaaaaaaaaaaaaaaaaaa no blast happned");
               arrcopy_rev(); 
              //showlblarr();
           }           
           setimgall();
           lblscore.setText("Score : "+score1);
           return flagblast;
       
    
    }
         @Override
     
      public void Down_Blast(int i , int j)
       {
           System.out.println(" in DOWN BLAST FUNC()");
           score1 = score1 + ( arr[i][j] * 100 );
           /*
           arr1[i][j] = 0;
           arr1[i+1][j]=0;
           arr1[i+2][j]=0;
           //animation func*/
           Down_Slide(i ,j);
           moves++;
                lblmoves.setText("MOVES : "+moves);
                countmoves();
          
       } 
          @Override
       public void Right_Blast(int i , int j)
       {           
           System.out.println(" in RIGHT BLAST FUNC()");
           score1 = score1 + (arr[i][j] * 50 );
           /*
           arr1[i][j] = 0;
           arr1[i][j+1]=0;
           arr1[i][j+2]=0;*/
           //animation func
           Right_Slide(i, j);
           moves++;
                lblmoves.setText("MOVES : "+moves);
                countmoves();
       }
           @Override
      public void Down_Slide(int i,int j)
       {
           if(i==0)
           {
                int x = rnd.nextInt(5)+1;
                arr1[0][j] = x;
                x = rnd.nextInt(5)+1;
                arr1[1][j]=x;
                x = rnd.nextInt(5)+1;
                arr1[2][j]=x;
                
           }
           else
           {
               int q = i; 
               for(int x=0;x<3;x++)
                {
                    int k=q;
                    do
                    {
                        arr1[k][j]=arr1[k-1][j];
                        k--;
                    }while(k>0);
                    arr1[0][j] = rnd.nextInt(5)+1;
                    q++;
                }
           }
       }
           
            @Override
              
       public void Right_Slide(int i,int j)
       {
           int q = i;
           if(i==0)
           {
                int x = rnd.nextInt(5)+1;
                arr1[0][j] = x;
                x = rnd.nextInt(5)+1;
                arr1[1][j]=x;
                x = rnd.nextInt(5)+1;
                arr1[2][j]=x;
           }
           else
           {
                do
                {
                    arr1[q][j]=arr1[q-1][j];
                    arr1[q][j+1]=arr1[q-1][j+1];
                    arr1[q][j+2]=arr1[q-1][j+2];
                    q=q-1;
                }while(q>0);
                int x = rnd.nextInt(5)+1;
                arr1[0][j] = x;
                x = rnd.nextInt(5)+1;
                arr1[0][j+1]=x;
                x = rnd.nextInt(5)+1;
                arr1[0][j+2]=x;
                
           }
       }
       

public void countmoves()
       {
           if(moves == 5)
           {    JOptionPane.showMessageDialog(null, "Compeleted Leve1 \n your score is "+ score1);
               new level2().setVisible(true);
                this.setVisible(false);
               //System.exit(0);
           }
       }

  
  
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        pnlhome1 = new javax.swing.JPanel();
        pb05 = new javax.swing.JLabel();
        pb02 = new javax.swing.JLabel();
        pb03 = new javax.swing.JLabel();
        pb04 = new javax.swing.JLabel();
        pb01 = new javax.swing.JLabel();
        pb06 = new javax.swing.JLabel();
        pb07 = new javax.swing.JLabel();
        pb10 = new javax.swing.JLabel();
        pb11 = new javax.swing.JLabel();
        pb12 = new javax.swing.JLabel();
        pb13 = new javax.swing.JLabel();
        pb14 = new javax.swing.JLabel();
        pb15 = new javax.swing.JLabel();
        pb16 = new javax.swing.JLabel();
        pb17 = new javax.swing.JLabel();
        pb00 = new javax.swing.JLabel();
        pb20 = new javax.swing.JLabel();
        pb21 = new javax.swing.JLabel();
        pb22 = new javax.swing.JLabel();
        pb23 = new javax.swing.JLabel();
        pb24 = new javax.swing.JLabel();
        pb25 = new javax.swing.JLabel();
        pb26 = new javax.swing.JLabel();
        pb27 = new javax.swing.JLabel();
        pb30 = new javax.swing.JLabel();
        pb31 = new javax.swing.JLabel();
        pb32 = new javax.swing.JLabel();
        pb33 = new javax.swing.JLabel();
        pb34 = new javax.swing.JLabel();
        pb35 = new javax.swing.JLabel();
        pb36 = new javax.swing.JLabel();
        pb37 = new javax.swing.JLabel();
        pb40 = new javax.swing.JLabel();
        pb41 = new javax.swing.JLabel();
        pb42 = new javax.swing.JLabel();
        pb43 = new javax.swing.JLabel();
        pb44 = new javax.swing.JLabel();
        pb45 = new javax.swing.JLabel();
        pb46 = new javax.swing.JLabel();
        pb47 = new javax.swing.JLabel();
        pb50 = new javax.swing.JLabel();
        pb51 = new javax.swing.JLabel();
        pb52 = new javax.swing.JLabel();
        pb53 = new javax.swing.JLabel();
        pb54 = new javax.swing.JLabel();
        pb55 = new javax.swing.JLabel();
        pb56 = new javax.swing.JLabel();
        pb57 = new javax.swing.JLabel();
        pb60 = new javax.swing.JLabel();
        pb61 = new javax.swing.JLabel();
        pb62 = new javax.swing.JLabel();
        pb63 = new javax.swing.JLabel();
        pb64 = new javax.swing.JLabel();
        pb65 = new javax.swing.JLabel();
        pb66 = new javax.swing.JLabel();
        pb67 = new javax.swing.JLabel();
        pb70 = new javax.swing.JLabel();
        pb71 = new javax.swing.JLabel();
        pb72 = new javax.swing.JLabel();
        pb73 = new javax.swing.JLabel();
        pb74 = new javax.swing.JLabel();
        pb75 = new javax.swing.JLabel();
        pb76 = new javax.swing.JLabel();
        pb77 = new javax.swing.JLabel();
        lblscore = new javax.swing.JLabel();
        lblname = new javax.swing.JLabel();
        lblmoves = new javax.swing.JLabel();
        btnback = new javax.swing.JButton();
        btnnext = new javax.swing.JButton();

        jLabel1.setText("jLabel1");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("home");
        setResizable(false);

        pnlhome1.setBackground(new java.awt.Color(153, 153, 153));

        pb05.setText("jLabel1");
        pb05.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb05MouseClicked(evt);
            }
        });

        pb02.setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/c3.jpg"))); // NOI18N
        pb02.setText("jLabel1");
        pb02.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb02MouseClicked(evt);
            }
        });

        pb03.setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/c4.jpg"))); // NOI18N
        pb03.setText("jLabel1");
        pb03.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb03MouseClicked(evt);
            }
        });

        pb04.setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/c5.jpg"))); // NOI18N
        pb04.setText("jLabel1");
        pb04.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb04MouseClicked(evt);
            }
        });

        pb01.setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/c2.png"))); // NOI18N
        pb01.setText("jLabel1");
        pb01.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb01MouseClicked(evt);
            }
        });

        pb06.setText("jLabel1");
        pb06.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb06MouseClicked(evt);
            }
        });

        pb07.setText("jLabel1");
        pb07.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb07MouseClicked(evt);
            }
        });

        pb10.setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/c2.png"))); // NOI18N
        pb10.setText("jLabel1");
        pb10.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb10MouseClicked(evt);
            }
        });

        pb11.setText("jLabel1");
        pb11.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb11MouseClicked(evt);
            }
        });

        pb12.setText("jLabel1");
        pb12.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb12MouseClicked(evt);
            }
        });

        pb13.setText("jLabel1");
        pb13.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb13MouseClicked(evt);
            }
        });

        pb14.setText("jLabel1");
        pb14.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb14MouseClicked(evt);
            }
        });

        pb15.setText("jLabel1");
        pb15.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb15MouseClicked(evt);
            }
        });

        pb16.setText("jLabel1");
        pb16.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb16MouseClicked(evt);
            }
        });

        pb17.setText("jLabel1");
        pb17.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb17MouseClicked(evt);
            }
        });

        pb00.setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/c1.png"))); // NOI18N
        pb00.setText("jLabel1");
        pb00.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb00MouseClicked(evt);
            }
        });

        pb20.setText("jLabel1");
        pb20.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb20MouseClicked(evt);
            }
        });

        pb21.setText("jLabel1");
        pb21.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb21MouseClicked(evt);
            }
        });

        pb22.setText("jLabel1");
        pb22.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb22MouseClicked(evt);
            }
        });

        pb23.setText("jLabel1");
        pb23.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb23MouseClicked(evt);
            }
        });

        pb24.setText("jLabel1");
        pb24.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb24MouseClicked(evt);
            }
        });

        pb25.setText("jLabel1");
        pb25.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb25MouseClicked(evt);
            }
        });

        pb26.setText("jLabel1");
        pb26.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb26MouseClicked(evt);
            }
        });

        pb27.setText("jLabel1");
        pb27.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb27MouseClicked(evt);
            }
        });

        pb30.setText("jLabel1");
        pb30.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb30MouseClicked(evt);
            }
        });

        pb31.setText("jLabel1");
        pb31.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb31MouseClicked(evt);
            }
        });

        pb32.setText("jLabel1");
        pb32.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb32MouseClicked(evt);
            }
        });

        pb33.setText("jLabel1");
        pb33.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb33MouseClicked(evt);
            }
        });

        pb34.setText("jLabel1");
        pb34.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb34MouseClicked(evt);
            }
        });

        pb35.setText("jLabel1");
        pb35.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb35MouseClicked(evt);
            }
        });

        pb36.setText("jLabel1");
        pb36.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb36MouseClicked(evt);
            }
        });

        pb37.setText("jLabel1");
        pb37.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb37MouseClicked(evt);
            }
        });

        pb40.setText("jLabel1");
        pb40.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb40MouseClicked(evt);
            }
        });

        pb41.setText("jLabel1");
        pb41.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb41MouseClicked(evt);
            }
        });

        pb42.setText("jLabel1");
        pb42.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb42MouseClicked(evt);
            }
        });

        pb43.setText("jLabel1");
        pb43.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb43MouseClicked(evt);
            }
        });

        pb44.setText("jLabel1");
        pb44.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb44MouseClicked(evt);
            }
        });

        pb45.setText("jLabel1");
        pb45.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb45MouseClicked(evt);
            }
        });

        pb46.setText("jLabel1");
        pb46.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb46MouseClicked(evt);
            }
        });

        pb47.setText("jLabel1");
        pb47.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb47MouseClicked(evt);
            }
        });

        pb50.setText("jLabel1");
        pb50.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb50MouseClicked(evt);
            }
        });

        pb51.setText("jLabel1");
        pb51.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb51MouseClicked(evt);
            }
        });

        pb52.setText("jLabel1");
        pb52.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb52MouseClicked(evt);
            }
        });

        pb53.setText("jLabel1");
        pb53.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb53MouseClicked(evt);
            }
        });

        pb54.setText("jLael1");
        pb54.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb54MouseClicked(evt);
            }
        });

        pb55.setText("jLabel1");
        pb55.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb55MouseClicked(evt);
            }
        });

        pb56.setText("jLabel1");
        pb56.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb56MouseClicked(evt);
            }
        });

        pb57.setText("jLabel1");
        pb57.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb57MouseClicked(evt);
            }
        });

        pb60.setText("jLabel1");
        pb60.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb60MouseClicked(evt);
            }
        });

        pb61.setText("jLabel1");
        pb61.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb61MouseClicked(evt);
            }
        });

        pb62.setText("jLabel1");
        pb62.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb62MouseClicked(evt);
            }
        });

        pb63.setText("jLabel1");
        pb63.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb63MouseClicked(evt);
            }
        });

        pb64.setText("jLabel1");
        pb64.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb64MouseClicked(evt);
            }
        });

        pb65.setText("jLabel1");
        pb65.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb65MouseClicked(evt);
            }
        });

        pb66.setText("jLabel1");
        pb66.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb66MouseClicked(evt);
            }
        });

        pb67.setText("jLabel1");
        pb67.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb67MouseClicked(evt);
            }
        });

        pb70.setText("jLabel1");
        pb70.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb70MouseClicked(evt);
            }
        });

        pb71.setText("jLabel1");
        pb71.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb71MouseClicked(evt);
            }
        });

        pb72.setText("jLabel1");
        pb72.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb72MouseClicked(evt);
            }
        });

        pb73.setText("jLabel1");
        pb73.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb73MouseClicked(evt);
            }
        });

        pb74.setText("jLabel1");
        pb74.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb74MouseClicked(evt);
            }
        });

        pb75.setText("jLabel1");
        pb75.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb75MouseClicked(evt);
            }
        });

        pb76.setText("jLabel1");
        pb76.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb76MouseClicked(evt);
            }
        });

        pb77.setText("jLabel1");
        pb77.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                pb77MouseClicked(evt);
            }
        });

        javax.swing.GroupLayout pnlhome1Layout = new javax.swing.GroupLayout(pnlhome1);
        pnlhome1.setLayout(pnlhome1Layout);
        pnlhome1Layout.setHorizontalGroup(
            pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlhome1Layout.createSequentialGroup()
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(pb70, javax.swing.GroupLayout.PREFERRED_SIZE, 39, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb50, javax.swing.GroupLayout.PREFERRED_SIZE, 39, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb40, javax.swing.GroupLayout.PREFERRED_SIZE, 39, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(pb20, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(pb10, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(pb00, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addComponent(pb30, javax.swing.GroupLayout.PREFERRED_SIZE, 37, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(pb60, javax.swing.GroupLayout.PREFERRED_SIZE, 39, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pb01, javax.swing.GroupLayout.PREFERRED_SIZE, 34, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb11, javax.swing.GroupLayout.PREFERRED_SIZE, 1, Short.MAX_VALUE)
                    .addComponent(pb21, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb31, javax.swing.GroupLayout.PREFERRED_SIZE, 1, Short.MAX_VALUE)
                    .addComponent(pb41, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb51, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb61, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb71, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pb02, javax.swing.GroupLayout.PREFERRED_SIZE, 34, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb12, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb22, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb32, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb42, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb52, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb62, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb72, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pb03, javax.swing.GroupLayout.PREFERRED_SIZE, 34, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb13, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb23, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb33, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb43, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb53, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb63, javax.swing.GroupLayout.PREFERRED_SIZE, 1, Short.MAX_VALUE)
                    .addComponent(pb73, javax.swing.GroupLayout.PREFERRED_SIZE, 1, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pb24, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb34, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb44, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb54, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb14, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb04, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb64, javax.swing.GroupLayout.PREFERRED_SIZE, 1, Short.MAX_VALUE)
                    .addComponent(pb74, javax.swing.GroupLayout.PREFERRED_SIZE, 1, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pb05, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb15, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb25, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb35, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb45, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb55, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb65, javax.swing.GroupLayout.PREFERRED_SIZE, 1, Short.MAX_VALUE)
                    .addComponent(pb75, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pb06, javax.swing.GroupLayout.PREFERRED_SIZE, 34, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb16, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb26, javax.swing.GroupLayout.PREFERRED_SIZE, 1, Short.MAX_VALUE)
                    .addComponent(pb36, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb46, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                    .addComponent(pb56, javax.swing.GroupLayout.PREFERRED_SIZE, 1, Short.MAX_VALUE)
                    .addComponent(pb66, javax.swing.GroupLayout.PREFERRED_SIZE, 1, Short.MAX_VALUE)
                    .addComponent(pb76, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(pb07, javax.swing.GroupLayout.PREFERRED_SIZE, 36, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb17)
                    .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                        .addComponent(pb47, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                        .addComponent(pb37, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                        .addComponent(pb27, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(pb57, javax.swing.GroupLayout.PREFERRED_SIZE, 41, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                        .addComponent(pb77, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 0, Short.MAX_VALUE)
                        .addComponent(pb67, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE))))
        );
        pnlhome1Layout.setVerticalGroup(
            pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(pnlhome1Layout.createSequentialGroup()
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(pb07, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(pb02, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(pb03, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(pb04)
                        .addComponent(pb05)
                        .addComponent(pb06, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(pb01, javax.swing.GroupLayout.PREFERRED_SIZE, 35, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(pb00)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(pb11, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(pb10, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(pb12, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb13, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb14, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb15, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb16, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb17, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pb20, javax.swing.GroupLayout.PREFERRED_SIZE, 33, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb21, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb22, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb23, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb24, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb25, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(pb26, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(pb27, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(pb31, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(pb30, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addComponent(pb32, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb33, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb34, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb35, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb36, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb37, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pb40, javax.swing.GroupLayout.PREFERRED_SIZE, 34, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb41, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb42, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb43, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb44, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb45, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb46, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb47, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pb50, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb51, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb52, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb53, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb54, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb55, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(pb56, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(pb57, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(pb60, javax.swing.GroupLayout.PREFERRED_SIZE, 34, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(pb61, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb62, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(pb63, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(pb64, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(pb65, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(pb66, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(pb67, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(pb70, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb71, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb72, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addGroup(pnlhome1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(pb73, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(pb74, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addComponent(pb75, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb76, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(pb77, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
        );

        lblscore.setFont(new java.awt.Font("Raavi", 3, 24)); // NOI18N
        lblscore.setText("jLabel1");

        lblname.setIcon(new javax.swing.ImageIcon(getClass().getResource("/pics/name.png"))); // NOI18N
        lblname.setText("jLabel3");

        lblmoves.setFont(new java.awt.Font("Raavi", 3, 24)); // NOI18N
        lblmoves.setText("jLabel2");

        btnback.setBackground(new java.awt.Color(255, 153, 0));
        btnback.setText("jButton1");
        btnback.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnbackActionPerformed(evt);
            }
        });

        btnnext.setBackground(new java.awt.Color(255, 153, 0));
        btnnext.setText("jButton1");
        btnnext.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnnextActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(0, 0, Short.MAX_VALUE)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(pnlhome1, javax.swing.GroupLayout.PREFERRED_SIZE, 322, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(lblmoves, javax.swing.GroupLayout.PREFERRED_SIZE, 150, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addGap(18, 18, 18)
                                .addComponent(lblscore, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                                .addContainerGap())
                            .addGroup(layout.createSequentialGroup()
                                .addGap(23, 23, 23)
                                .addComponent(lblname, javax.swing.GroupLayout.PREFERRED_SIZE, 269, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(btnback)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(btnnext)
                        .addContainerGap())))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addComponent(lblname, javax.swing.GroupLayout.PREFERRED_SIZE, 68, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnback)
                    .addComponent(btnnext))
                .addGap(31, 31, 31)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(lblmoves)
                    .addComponent(lblscore))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 74, Short.MAX_VALUE)
                .addComponent(pnlhome1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void pb00MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb00MouseClicked
        // TODO add your handling code here:
        
        
            if (flag == 0)
            {
                flag = 1;
                i1 = 0;
                j1 = 0;
                System.out.println("00");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 0;
                j2 = 0;
                System.out.println("00");
                int f2 =0;
                do{
                    f2=CheckAll();
                    
                }while(f2==1);
            }
                 
                
                
                
    }//GEN-LAST:event_pb00MouseClicked

    private void pb01MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb01MouseClicked
        // TODO add your handling code here:
        
        if (flag == 0)
            {
                flag = 1;
                i1 = 0;
                j1 = 1;
                System.out.println("01");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 0;
                j2 = 1;
                System.out.println("01");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
                 
               
            }
    }//GEN-LAST:event_pb01MouseClicked

    private void pb02MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb02MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 0;
                j1 = 2;
                System.out.println("02");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 0;
                j2 = 2;
                System.out.println("02");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
                  
            }
    }//GEN-LAST:event_pb02MouseClicked

    private void pb04MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb04MouseClicked
        // TODO add your handling code here:
        
        if (flag == 0)
            {
                flag = 1;
                i1 = 0;
                j1 = 4;
                System.out.println("04");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 0;
                j2 = 4;
                System.out.println("04");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
            }
    }//GEN-LAST:event_pb04MouseClicked

    private void pb03MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb03MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 0;
                j1 = 3;
                System.out.println("03");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 0;
                j2 = 3;
                System.out.println("03");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
              
            }
        
    }//GEN-LAST:event_pb03MouseClicked

    private void pb05MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb05MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 0;
                j1 = 5;
                System.out.println("05");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 0;
                j2 = 5;
                System.out.println("05");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
              
            }
    }//GEN-LAST:event_pb05MouseClicked

    private void pb06MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb06MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 0;
                j1 = 6;
                System.out.println("06");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 0;
                j2 = 6;
                System.out.println("06");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
          
                
            }
    }//GEN-LAST:event_pb06MouseClicked

    private void pb07MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb07MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 0;
                j1 = 7;
                System.out.println("07");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 0;
                j2 = 7;
                System.out.println("o7");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
                        
            }
    }//GEN-LAST:event_pb07MouseClicked

    private void pb10MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb10MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 1;
                j1 = 0;
                System.out.println("10");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 1;
                j2 = 0;
                System.out.println("10");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
               
            }
    }//GEN-LAST:event_pb10MouseClicked

    private void pb11MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb11MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 1;
                j1 = 1;
                System.out.println("11");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 1;
                j2 = 1;
                System.out.println("11");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
           
            }
    }//GEN-LAST:event_pb11MouseClicked

    private void pb12MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb12MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 1;
                j1 = 2;
                System.out.println("12");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 1;
                j2 = 2;
                System.out.println("12");     
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);    
               
            }
    }//GEN-LAST:event_pb12MouseClicked

    private void pb13MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb13MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 1;
                j1 = 3;
                System.out.println("13");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 1;
                j2 = 3;
                System.out.println("13");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
             
            }
    }//GEN-LAST:event_pb13MouseClicked

    private void pb14MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb14MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 1;
                j1 = 4;
                System.out.println("14");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 1;
                j2 = 4;
                System.out.println("14");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
              
            }
    }//GEN-LAST:event_pb14MouseClicked

    private void pb15MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb15MouseClicked
        // TODO add your handling code here:
        
        if (flag == 0)
            {
                flag = 1;
                i1 = 1;
                j1 = 5;
                System.out.println("15");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 1;
                j2 = 5;
                System.out.println("15");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
              
            }
    }//GEN-LAST:event_pb15MouseClicked

    private void pb16MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb16MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 1;
                j1 = 6;
                System.out.println("16");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 1;
                j2 = 6;
                System.out.println("16");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
               
            }
    }//GEN-LAST:event_pb16MouseClicked

    private void pb17MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb17MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 1;
                j1 = 7;
                System.out.println("17");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 1;
                j2 = 7;
                System.out.println("17");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
               
            }
    }//GEN-LAST:event_pb17MouseClicked

    private void pb20MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb20MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 2;
                j1 = 0;
                System.out.println("20");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 2;
                j2 = 0;
                System.out.println("20");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
               
            }
    }//GEN-LAST:event_pb20MouseClicked

    private void pb21MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb21MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 2;
                j1 = 1;
                System.out.println("21");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 2;
                j2 = 1;
                System.out.println("21");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);              
               
            }
    }//GEN-LAST:event_pb21MouseClicked

    private void pb22MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb22MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 2;
                j1 = 2;
                System.out.println("22");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 2;
                j2 = 2;
                System.out.println("22");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);              
               
            }
    }//GEN-LAST:event_pb22MouseClicked

    private void pb23MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb23MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 2;
                j1 = 3;
                System.out.println("23");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 2;
                j2 = 3;
                System.out.println("23");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);              
                
            }
    }//GEN-LAST:event_pb23MouseClicked

    private void pb24MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb24MouseClicked
        // TODO add your handling code here:
        
        if (flag == 0)
            {
                flag = 1;
                i1 = 2;
                j1 = 4;
                System.out.println("24");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 2;
                j2 = 4;
                System.out.println("24");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);              
                
            }
    }//GEN-LAST:event_pb24MouseClicked

    private void pb25MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb25MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 2;
                j1 = 5;
                System.out.println("25");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 2;
                j2 = 5;
                System.out.println("25");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);              
              
            }
    }//GEN-LAST:event_pb25MouseClicked

    private void pb26MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb26MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 2;
                j1 = 6;
                System.out.println("26");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 2;
                j2 = 6;
                System.out.println("26");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);              
               
            }
    }//GEN-LAST:event_pb26MouseClicked

    private void pb27MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb27MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 2;
                j1 = 7;
                System.out.println("27");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 2;
                j2 = 7;
                System.out.println("27");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);              
               
            }
    }//GEN-LAST:event_pb27MouseClicked

    private void pb30MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb30MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 3;
                j1 = 0;
                System.out.println("30");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 3;
                j2 = 0;
                System.out.println("30");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);              
               
            }
    }//GEN-LAST:event_pb30MouseClicked

    private void pb31MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb31MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 3;
                j1 = 1;
                System.out.println("31");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 3;
                j2 = 1;
                System.out.println("31");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);              
              
            }
    }//GEN-LAST:event_pb31MouseClicked

    private void pb32MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb32MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 3;
                j1 = 2;
                System.out.println("32");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 3;
                j2 = 2;
                System.out.println("32");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);              
               
            }
    }//GEN-LAST:event_pb32MouseClicked

    private void pb33MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb33MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 3;
                j1 = 3;
                System.out.println("33");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 3;
                j2 = 3;
                System.out.println("33");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);       
                 
            }
    }//GEN-LAST:event_pb33MouseClicked

    private void pb34MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb34MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 3;
                j1 = 4;
                System.out.println("34");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 3;
                j2 = 4;
                System.out.println("34");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);       
               
            }
    }//GEN-LAST:event_pb34MouseClicked

    private void pb35MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb35MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 3;
                j1 = 5;
                System.out.println("35");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 3;
                j2 = 5;
                System.out.println("35");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);       
                
            }
    }//GEN-LAST:event_pb35MouseClicked

    private void pb36MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb36MouseClicked
        // TODO add your handling code here:
        
        if (flag == 0)
            {
                flag = 1;
                i1 = 3;
                j1 = 6;
                System.out.println("36");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 3;
                j2 = 6;
                System.out.println("36");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);       
                
            }
    }//GEN-LAST:event_pb36MouseClicked

    private void pb37MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb37MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 3;
                j1 = 7;
                System.out.println("37");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 3;
                j2 = 7;
                System.out.println("37");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);
                
            }
    }//GEN-LAST:event_pb37MouseClicked

    private void pb40MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb40MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 4;
                j1 = 0;
                System.out.println("40");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 4;
                j2 = 0;
                System.out.println("40");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);       
                
            }
    }//GEN-LAST:event_pb40MouseClicked

    private void pb41MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb41MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 4;
                j1 = 1;
                System.out.println("41");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 4;
                j2 = 1;
                System.out.println("41");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);       
                
            }
    }//GEN-LAST:event_pb41MouseClicked

    private void pb42MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb42MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 4;
                j1 = 2;
                System.out.println("42");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 4;
                j2 = 2;
                System.out.println("42");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);       
                
            }
    }//GEN-LAST:event_pb42MouseClicked

    private void pb43MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb43MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 4;
                j1 = 3;
                System.out.println("43");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 4;
                j2 = 3;
                System.out.println("43");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);       
                
            }
    }//GEN-LAST:event_pb43MouseClicked

    private void pb44MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb44MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 4;
                j1 = 4;
                System.out.println("44");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 4;
                j2 = 4;
                System.out.println("44");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);                       
            }
    }//GEN-LAST:event_pb44MouseClicked

    private void pb45MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb45MouseClicked
        // TODO add your handling code here:
        
        if (flag == 0)
            {
                flag = 1;
                i1 = 4;
                j1 = 5;
                System.out.println("45");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 4;
                j2 = 5;
                System.out.println("45");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);       
                
            }
    }//GEN-LAST:event_pb45MouseClicked

    private void pb46MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb46MouseClicked
        // TODO add your handling code here:
        
        if (flag == 0)
            {
                flag = 1;
                i1 = 4;
                j1 = 6;
                System.out.println("46");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 4;
                j2 = 6;
                System.out.println("46");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);       
                
            }
    }//GEN-LAST:event_pb46MouseClicked

    private void pb47MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb47MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 4;
                j1 = 7;
                System.out.println("47");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 4;
                j2 = 7;
                System.out.println("47");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);       
                
            }
    }//GEN-LAST:event_pb47MouseClicked

    private void pb50MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb50MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 5;
                j1 = 0;
                System.out.println("50");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 5;
                j2 = 0;
                System.out.println("50");
                int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1);                      
            }
    }//GEN-LAST:event_pb50MouseClicked

    private void pb51MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb51MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 5;
                j1 = 1;
                System.out.println("51");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 5;
                j2 = 1;
                System.out.println("51");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
                
            }
    }//GEN-LAST:event_pb51MouseClicked

    private void pb52MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb52MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 5;
                j1 = 2;
                System.out.println("52");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 5;
                j2 = 2;
                System.out.println("52");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb52MouseClicked

    private void pb53MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb53MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 5;
                j1 = 3;
                System.out.println("53");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 5;
                j2 = 3;
                System.out.println("53");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
                
            }
    }//GEN-LAST:event_pb53MouseClicked

    private void pb54MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb54MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 5;
                j1 = 4;
                System.out.println("54");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 5;
                j2 = 4;
                System.out.println("54");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
                
            }
    }//GEN-LAST:event_pb54MouseClicked

    private void pb55MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb55MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 5;
                j1 = 5;
                System.out.println("55");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 5;
                j2 = 5;
                System.out.println("55");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
                
            }
    }//GEN-LAST:event_pb55MouseClicked

    private void pb56MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb56MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 5;
                j1 = 6;
                System.out.println("56");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 5;
                j2 = 6;
                System.out.println("56");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb56MouseClicked

    private void pb57MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb57MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 5;
                j1 = 7;
                System.out.println("57");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 5;
                j2 = 7;
                System.out.println("57");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb57MouseClicked

    private void pb60MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb60MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 6;
                j1 = 0;
                System.out.println("60");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 6;
                j2 = 0;
                System.out.println("60");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb60MouseClicked

    private void pb61MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb61MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 6;
                j1 = 1;
                System.out.println("61");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 6;
                j2 = 1;
                System.out.println("61");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb61MouseClicked

    private void pb62MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb62MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 6;
                j1 = 2;
                System.out.println("62");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 6;
                j2 = 2;
                System.out.println("62");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb62MouseClicked

    private void pb63MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb63MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 6;
                j1 = 3;
                System.out.println("63");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 6;
                j2 = 3;
                System.out.println("63");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb63MouseClicked

    private void pb64MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb64MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 6;
                j1 = 4;
                System.out.println("64");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 6;
                j2 = 4;
                System.out.println("64");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb64MouseClicked

    private void pb65MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb65MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 6;
                j1 = 5;
                System.out.println("65");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 6;
                j2 = 5;
                System.out.println("65");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb65MouseClicked

    private void pb66MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb66MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 6;
                j1 = 6;
                System.out.println("66");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 6;
                j2 = 6;
                System.out.println("66");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb66MouseClicked

    private void pb67MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb67MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 6;
                j1 = 7;
                System.out.println("67");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 6;
                j2 = 7;
                System.out.println("67");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb67MouseClicked

    private void pb70MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb70MouseClicked
        // TODO add your handling code here:
         if (flag == 0)
            {
                flag = 1;
                i1 = 7;
                j1 = 0;
                System.out.println("70");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 7;
                j2 = 0;
                System.out.println("70");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb70MouseClicked

    private void pb71MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb71MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 7;
                j1 = 1;
                System.out.println("71");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 7;
                j2 = 1;
                System.out.println("71");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb71MouseClicked

    private void pb72MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb72MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 7;
                j1 = 2;
                System.out.println("72");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 7;
                j2 = 2;
                System.out.println("72");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb72MouseClicked

    private void pb73MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb73MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 7;
                j1 = 3;
                System.out.println("73");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 7;
                j2 = 3;
                System.out.println("73");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb73MouseClicked

    private void pb74MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb74MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 7;
                j1 = 4;
                System.out.println("74");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 7;
                j2 = 4;
                System.out.println("74");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb74MouseClicked

    private void pb75MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb75MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 7;
                j1 = 5;
                System.out.println("75");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 7;
                j2 = 5;
                System.out.println("75");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb75MouseClicked

    private void pb76MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb76MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 7;
                j1 = 6;
                System.out.println("76");
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 7;
                j2 = 6;
                System.out.println("76");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb76MouseClicked

    private void pb77MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_pb77MouseClicked
        // TODO add your handling code here:
        if (flag == 0)
            {
                flag = 1;
                i1 = 7;
                j1 = 7;
                System.out.println("77");
                
            }
            else if(flag==1)
            {
                flag = 0;
                i2 = 7;
                j2 = 7;
                System.out.println("77");
                 int f2 =0;
                do{
                    f2=CheckAll();
                }while(f2==1); 
            }
    }//GEN-LAST:event_pb77MouseClicked

    private void btnnextActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnnextActionPerformed
        // TODO add your handling code here:
        new level2().setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnnextActionPerformed

    private void btnbackActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnbackActionPerformed
        // TODO add your handling code here:
        new opening().setVisible(true);
        this.setVisible(false);
    }//GEN-LAST:event_btnbackActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(level1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(level1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(level1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(level1.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new level1().setVisible(true);
                
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnback;
    private javax.swing.JButton btnnext;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel lblmoves;
    private javax.swing.JLabel lblname;
    private javax.swing.JLabel lblscore;
    private javax.swing.JLabel pb00;
    private javax.swing.JLabel pb01;
    private javax.swing.JLabel pb02;
    private javax.swing.JLabel pb03;
    private javax.swing.JLabel pb04;
    private javax.swing.JLabel pb05;
    private javax.swing.JLabel pb06;
    private javax.swing.JLabel pb07;
    private javax.swing.JLabel pb10;
    private javax.swing.JLabel pb11;
    private javax.swing.JLabel pb12;
    private javax.swing.JLabel pb13;
    private javax.swing.JLabel pb14;
    private javax.swing.JLabel pb15;
    private javax.swing.JLabel pb16;
    private javax.swing.JLabel pb17;
    private javax.swing.JLabel pb20;
    private javax.swing.JLabel pb21;
    private javax.swing.JLabel pb22;
    private javax.swing.JLabel pb23;
    private javax.swing.JLabel pb24;
    private javax.swing.JLabel pb25;
    private javax.swing.JLabel pb26;
    private javax.swing.JLabel pb27;
    private javax.swing.JLabel pb30;
    private javax.swing.JLabel pb31;
    private javax.swing.JLabel pb32;
    private javax.swing.JLabel pb33;
    private javax.swing.JLabel pb34;
    private javax.swing.JLabel pb35;
    private javax.swing.JLabel pb36;
    private javax.swing.JLabel pb37;
    private javax.swing.JLabel pb40;
    private javax.swing.JLabel pb41;
    private javax.swing.JLabel pb42;
    private javax.swing.JLabel pb43;
    private javax.swing.JLabel pb44;
    private javax.swing.JLabel pb45;
    private javax.swing.JLabel pb46;
    private javax.swing.JLabel pb47;
    private javax.swing.JLabel pb50;
    private javax.swing.JLabel pb51;
    private javax.swing.JLabel pb52;
    private javax.swing.JLabel pb53;
    private javax.swing.JLabel pb54;
    private javax.swing.JLabel pb55;
    private javax.swing.JLabel pb56;
    private javax.swing.JLabel pb57;
    private javax.swing.JLabel pb60;
    private javax.swing.JLabel pb61;
    private javax.swing.JLabel pb62;
    private javax.swing.JLabel pb63;
    private javax.swing.JLabel pb64;
    private javax.swing.JLabel pb65;
    private javax.swing.JLabel pb66;
    private javax.swing.JLabel pb67;
    private javax.swing.JLabel pb70;
    private javax.swing.JLabel pb71;
    private javax.swing.JLabel pb72;
    private javax.swing.JLabel pb73;
    private javax.swing.JLabel pb74;
    private javax.swing.JLabel pb75;
    private javax.swing.JLabel pb76;
    private javax.swing.JLabel pb77;
    private javax.swing.JPanel pnlhome1;
    // End of variables declaration//GEN-END:variables

   
}
