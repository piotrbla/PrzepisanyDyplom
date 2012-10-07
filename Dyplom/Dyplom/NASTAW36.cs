// uses
// graph,crt,dos;
// var
// q,a,z,n,k,m,i,b,uciec,nrekranu,cr1:integer;
// starynr,n1:byte;
// ch:char;
// {===========================================================================}
// {Procedury rysujace ogonki do polskich liter}
// procedure pzl(wsx,wsy:integer);
// begin
 // line(wsx,wsy,wsx+3,wsy-3);
// end;
// procedure pzae(wsx,wsy:integer);
// begin
 // line(wsx,wsy,wsx+1,wsy+1);
// end;
// procedure pzcoz(wsx,wsy:integer);
// begin
 // line(wsx,wsy,wsx+1,wsy-1);
// end;
// procedure pzz(wsx,wsy:integer);
// begin
 // circle(wsx,wsy,1);
// end;

// procedure pisz(wsx,wsy:integer; napis:string);
// var c:integer;
// znakp:string;
// begin
 // c:=length(napis);
 // for i:=1 to c do
  // begin
   // znakp:=copy(napis,i,1);
   // if znakp='q' then pzcoz(wsx-3,wsy+1) else
   // if znakp='l' then pzl(wsx-7,wsy+8) else
   // if znakp='z' then pzz(wsx-3,wsy+0) else
   // if znakp='a' then pzae(wsx-2,wsy+10) else
   // begin outtextxy(wsx,wsy,znakp);wsx:=wsx+6;end;
  // end;
 // end;
// {====================================================================================}
// procedure sygnal(wsx,wsy,on:integer;kwad:boolean);{PROCEDURA RYSOWANIA SYGALIZATORA}
 // begin
  // setcolor(3);
  // circle(wsx,wsy,9);
  // setfillstyle(0,0);
  // floodfill(wsx,wsy,3);
   // fillellipse(wsx,wsy,9,6);
     // case on of
    // 0:line(wsx-9,wsy,wsx+9,wsy);
    // 1:line(wsx,wsy-7,wsx,wsy+7);
    // 2:line(wsx-5,wsy-5,wsx+5,wsy+5);
   // end;
  // if kwad then rectangle(wsx-10,wsy-7,wsx+10,wsy+7);
 // end;
// {==================================================================================}
// procedure miernik(lwx,lwy,zak:integer;miano:string;ram:boolean);{procedura rysujaca miernik}
 // begin
  // setcolor(3);
  // rectangle(lwx,lwy,lwx+7*zak,lwy+20);
  // if ram then rectangle(lwx-2,lwy-2,lwx+7*zak+2,lwy+22);
  // settextstyle(smallfont,horizdir,4);
  // outtextxy(lwx+4,lwy+9,miano);
 // end;
// {================================================================================}
// procedure uziemienie(wsx,wsy:integer);{procedura rysujaca uziemienie}
 // begin
  // line(wsx-5,wsy+10,wsx+5,wsy+10);
  // line(wsx-3,wsy+12,wsx+3,wsy+12);
  // line(wsx-1,wsy+14,wsx+1,wsy+14);
  // line(wsx,wsy,wsx,wsy+10);
 // end;
// {=================================================================================}
// procedure lacznik(wsx,wsy,pos:integer);{Procedura rysujaca lacznik wielopozycyjny}
// var kat:integer;
 // begin
  // setcolor(3);
  // setfillstyle(0,1);
  // circle(wsx,wsy,10);
  // floodfill(wsx,wsy,3);
  // circle(wsx,wsy,13);
  // setcolor(3);
  // kat:=(45*pos);
  // arc(wsx,wsy,kat,kat+180,3);
  // case pos of
   // 0:begin line(wsx-3,wsy,wsx,wsy+7);line(wsx+3,wsy,wsx,wsy+7);end;
   // 1:begin line(wsx-2,wsy+2,wsx+6,wsy+6);line(wsx+2,wsy-2,wsx+6,wsy+6);end;
   // 2:begin line(wsx,wsy-2,wsx+9,wsy);line(wsx,wsy+2,wsx+9,wsy);end;
   // 3:begin line(wsx-3,wsy-1,wsx+6,wsy-6);line(wsx+2,wsy+2,wsx+6,wsy-6);end;
   // 4:begin line(wsx-3,wsy,wsx,wsy-7);line(wsx+3,wsy,wsx,wsy-7);end;
   // 5:begin line(wsx+2,wsy-2,wsx-6,wsy-6);line(wsx-2,wsy+2,wsx-6,wsy-6);end;
   // 6:begin line(wsx,wsy-2,wsx-9,wsy);line(wsx,wsy+2,wsx-9,wsy);end;
   // 7:begin line(wsx+3,wsy+1,wsx-6,wsy+6);line(wsx-2,wsy-2,wsx-6,wsy+6);end;
  // end;
 // end;
// {==============================================================================================}
// procedure trafo(wsx,wsy:integer;faz:boolean);{procedura rysujaca transformator 1- lub 3- fazowy}
  // begin
    // circle(wsx,wsy+15,10);
    // if not faz then circle(wsx,wsy+23,10) else begin
      // circle(wsx-8,wsy+23,10);
      // circle(wsx+8,wsy+23,10);
    // line(wsx,wsy,wsx,wsy+8);
    // line(wsx-17,wsy+28,wsx-30,wsy+35);
    // line(wsx+17,wsy+28,wsx+30,wsy+35);
// end;end;
// {=================================================================================}
// procedure stacyjka(wsx,wsy:integer);
 // begin
  // setcolor(3);
  // circle(wsx,wsy,10);
  // circle(wsx,wsy,7);
  // circle(wsx,wsy,3);
// end;
// {===============================================================================}
// procedure lampka(wsx,wsy:integer;syg:boolean);{procedura rysujaca lampke}
// begin
 // setcolor(1);
 // rectangle(wsx,wsy,wsx+12,wsy+11);
 // rectangle(wsx+2,wsy+2,wsx+10,wsy+9);
 // setfillstyle(6,0);floodfill(wsx+3,wsy+3,1);
 // if syg then begin setfillstyle(6,2);floodfill(wsx+3,wsy+3,1);end;
 // setcolor(3);
// end;
// {===============================================================================}
// procedure glowica(wsx,wsy:integer);{procodura rysujaca glowice kablowa}
// var s:integer;
// begin
  // for s:=wsx-3 to wsx+3 do
  // line(s,wsy,wsx,wsy+9);
// end;
// {==============================================================================}
// procedure wezel(wsx,wsy:integer);
  // begin
  // setfillstyle(1,1);
  // fillellipse(wsx,wsy,2,2);
// end;
// {===================================================================================================}
// procedure lamp_wsk(wsx,wsy,wyb:integer);{PROCEDURA RYSUJACA ZESTAW LAMPEK SYGNALIZACYJNCH}
// var q,a,d:integer;
 // begin
  // setcolor(3);
  // line(wsx,wsy,wsx+24,wsy);
  // line(wsx,wsy+34,wsx+24,wsy+34);
  // line(wsx,wsy,wsx,wsy+34);
  // line(wsx+24,wsy,wsx+24,wsy+34);
 // line(wsx+2,wsy+2,wsx+22,wsy+2);
 // line(wsx+2,wsy+32,wsx+22,wsy+32);
 // line(wsx+2,wsy+2,wsx+2,wsy+32);
 // line(wsx+22,wsy+2,wsx+22,wsy+32);
 // for a:=1 to 5 do
 // line(wsx+2,wsy+2+6*a,wsx+22,wsy+2+6*a);
 // line(wsx+12,wsy+2,wsx+12,wsy+32);
   // setfillstyle(6,2);
 // case wyb of
// 0:floodfill(wsx+4,wsy+4,3);
// 1:floodfill(wsx+4,wsy+10,3);
// 2:floodfill(wsx+4,wsy+16,3);
// 3:floodfill(wsx+4,wsy+22,3);
// 4:floodfill(wsx+4,wsy+28,3);
// 5:floodfill(wsx+14,wsy+4,3);
// 6:floodfill(wsx+14,wsy+10,3);
// 7:floodfill(wsx+14,wsy+16,3);
// 8:floodfill(wsx+14,wsy+22,3);
// 9:floodfill(wsx+14,wsy+28,3);
// end;
// setcolor(3);
 // end;
// {===============================================================================}
// procedure przeklad(wsx,wsy:word);{PROCEDURA RYSUJANCA PRZEKLADNIK }
 // begin
 // setcolor(3);
 // circle(wsx,wsy+8,7);
 // arc(wsx,wsy+8,0,180,10);end;
// {=================================================================================}
// procedure pol_pom1  {PROCEDURA RYSUJACA CALE POLE POMIAROWE NR 9}
// (wsx,wsy,lon1,lon2,syg3,syg4,syg6,syg7,syg8,wyb:integer;ls5:boolean);
 // var m,n:integer;
  // begin
  // miernik(wsx+55,wsy+20,4,'MW',true);
  // miernik(wsx+55,wsy+44,4,'Mvar',true);
  // miernik(wsx+55,wsy+68,4,'kV',true);
  // lacznik(wsx+113,wsy+78,lon1);
  // lacznik(wsx+69,wsy+110,lon2);
   // line(wsx,wsy+130,wsx+getmaxx div 2,wsy+130);
   // line(wsx,wsy+131,wsx+getmaxx div 2,wsy+131);
   // line(wsx,wsy+138,wsx+getmaxx div 2,wsy+138);
   // line(wsx,wsy+139,wsx+getmaxx div 2,wsy+139);
  // wezel(wsx+50,wsy+131);
  // wezel(wsx+90,wsy+139);
   // sygnal(wsx+50,wsy+165,syg3,false);line(wsx+50,wsy+132,wsx+50,wsy+158);
   // sygnal(wsx+90,wsy+165,syg4,false);line(wsx+90,wsy+140,wsx+90,wsy+158);
  // wezel(wsx+70,wsy+182);line(wsx+50,wsy+182,wsx+90,wsy+182);
   // line(wsx+50,wsy+172,wsx+50,wsy+182);line(wsx+90,wsy+172,wsx+90,wsy+182);
   // sygnal(wsx+70,wsy+205,syg6,true);line(wsx+70,wsy+182,wsx+70,wsy+197);
   // lampka(wsx+35,wsy+200,ls5);
   // stacyjka(wsx+105,wsy+205);
   // miernik(wsx+57,wsy+230,4,'A',true);line(wsx+70,wsy+212,wsx+70,wsy+228);
   // sygnal(wsx+70,wsy+270,syg7,false);line(wsx+70,wsy+252,wsx+70,wsy+263);
 // wezel(wsx+70,wsy+285);line(wsx+70,wsy+277,wsx+70,wsy+319);
   // sygnal(wsx+105,wsy+305,syg8,true);line(wsx+70,wsy+285,wsx+105,wsy+285);line(wsx+105,wsy+285,wsx+105,wsy+297);
   // uziemienie(wsx+105,wsy+312);glowica(wsx+70,wsy+318);
   // lamp_wsk(wsx+150,wsy+285,wyb);
    // setcolor(3);
    // settextstyle(smallfont,horizdir,4);outtextxy(wsx+130,wsy+5,'El SZCZECIN');
    // outtextxy(wsx+35,wsy+210,'13');
    // outtextxy(wsx+120,wsy+195,'LSy');
    // outtextxy(wsx+108,wsy+87,'48');outtextxy(wsx+64,wsy+119,'12');
    // outtextxy(wsx+90,wsy+60,'LV');
    // outtextxy(wsx+10,wsy+195,'LS');
// end;
// {================================================================================}
// procedure pol_pom2   {PROCEDURA RYSUJACA CALE POLE POMIAROWE NR 15}
 // (wsx,wsy,lon1,lon2,lon3,lon4,syg1,syg2,syg3,syg4,syg5,syg6,syg7,syg8,syg9,syg10:integer;syg11,syg12:boolean);
 // var m,n:integer;
  // begin setcolor(3);
  // settextstyle(smallfont,horizdir,4);
  // pisz(wsx+40,wsy+5,'GUMIENqCE');outtextxy(20,119,'110kV');
  // lamp_wsk(wsx+130,wsy+285,4);
  // miernik(wsx+50,wsy+20,4,'MW',true);
  // miernik(wsx+50,wsy+44,4,'Mvar',true);
  // miernik(wsx+50,wsy+68,4,'kV',true);
  // lacznik(wsx+110,wsy+78,lon1);outtextxy(wsx+93,wsy+58,'LV');outtextxy(wsx+105,wsy+88,'20');
  // lacznik(wsx+64,wsy+110,lon3);outtextxy(wsx+41,wsy+93,'LV');outtextxy(wsx+59,wsy+119,'12');
   // line(wsx,wsy+130,wsx+getmaxx div 2,wsy+130);
   // line(wsx,wsy+131,wsx+getmaxx div 2,wsy+131);
   // line(wsx,wsy+138,wsx+getmaxx div 2,wsy+138);
   // line(wsx,wsy+139,wsx+getmaxx div 2,wsy+139);
  // wezel(wsx+55,wsy+131);
  // wezel(wsx+95,wsy+139);
   // sygnal(wsx+55,wsy+165,syg3,false);line(wsx+55,wsy+132,wsx+55,wsy+158);
   // sygnal(wsx+95,wsy+165,syg4,false);line(wsx+95,wsy+140,wsx+95,wsy+158);
  // wezel(wsx+75,wsy+182);line(wsx+55,wsy+182,wsx+95,wsy+182);
   // line(wsx+55,wsy+172,wsx+55,wsy+182);line(wsx+95,wsy+172,wsx+95,wsy+182);
   // sygnal(wsx+75,wsy+205,syg6,true);line(wsx+75,wsy+182,wsx+75,wsy+197);
   // lampka(wsx+40,wsy+200,syg11);outtextxy(wsx+20,wsy+200,'LS');outtextxy(wsx+41,wsy+211,'13');
   // stacyjka(wsx+110,wsy+205);outtextxy(wsx+125,wsy+193,'LSy');
   // miernik(wsx+62,wsy+230,4,'A',true);line(wsx+75,wsy+212,wsx+75,wsy+228);
   // sygnal(wsx+75,wsy+270,syg7,false);line(wsx+75,wsy+252,wsx+75,wsy+263);
 // wezel(wsx+75,wsy+285);line(wsx+75,wsy+277,wsx+75,wsy+319);
   // sygnal(wsx+100,wsy+305,syg8,true);line(wsx+100,wsy+285,wsx+75,wsy+285);line(wsx+100,wsy+285,wsx+100,wsy+297);
   // uziemienie(wsx+100,wsy+312);glowica(wsx+75,wsy+318);
// {------------------------------------------------------------------------------------------------------------}
  // pisz(wsx+200,wsy+5,'BIALlOWIESKA');
  // miernik(wsx+220,wsy+20,4,'MW',true);
  // miernik(wsx+220,wsy+44,4,'Mvar',true);
  // miernik(wsx+220,wsy+68,4,'kV',true);
  // lacznik(wsx+190,wsy+78,lon2);outtextxy(wsx+170,wsy+58,'LS');outtextxy(wsx+185,wsy+88,'20');
  // lacznik(wsx+235,wsy+110,lon4);outtextxy(wsx+212,wsy+93,'LS');outtextxy(wsx+230,wsy+119,'12');
    // wezel(wsx+255,wsy+131);
    // wezel(wsx+215,wsy+139);
   // sygnal(wsx+255,wsy+165,syg4,true);line(wsx+255,wsy+132,wsx+255,wsy+158);
   // sygnal(wsx+215,wsy+165,syg5,true);line(wsx+215,wsy+140,wsx+215,wsy+158);
  // wezel(wsx+235,wsy+182);line(wsx+256,wsy+182,wsx+215,wsy+182);
   // line(wsx+255,wsy+172,wsx+255,wsy+182);line(wsx+215,wsy+172,wsx+215,wsy+182);
   // sygnal(wsx+235,wsy+205,syg6,true);line(wsx+235,wsy+182,wsx+235,wsy+197);
   // lampka(wsx+200,wsy+200,syg12);outtextxy(wsx+180,wsy+200,'LS');outtextxy(wsx+201,wsy+211,'13');
   // stacyjka(wsx+270,wsy+205);outtextxy(wsx+285,wsy+193,'LSy');
   // miernik(wsx+222,wsy+230,4,'A',true);line(wsx+235,wsy+212,wsx+235,wsy+228);
   // sygnal(wsx+235,wsy+270,syg8,true);line(wsx+235,wsy+252,wsx+235,wsy+263);
 // wezel(wsx+235,wsy+285);line(wsx+235,wsy+277,wsx+235,wsy+319);
   // sygnal(wsx+260,wsy+305,syg8,true);line(wsx+235,wsy+285,wsx+260,wsy+285);line(wsx+260,wsy+285,wsx+260,wsy+297);
   // uziemienie(wsx+260,wsy+312);glowica(wsx+235,wsy+318);
    // lamp_wsk(wsx+180,wsy+285,4);
 // end;
// {================================================================================================================}
// procedure pol_pom3  {PROCEDURA RYSUJACA CALE POLE POMIAROWE NR 16}
// (wsx,wsy,lon1,lon2,syg3,syg4,syg6,syg7,syg8,syg9,syg10,syg11,syg12,syg14:word;ls1,ls2:boolean);
 // var m,n:integer;
  // begin
   // setcolor(3);
   // settextstyle(smallfont,horizdir,4);
  // outtextxy(wsx+40,wsy+5,'GLINKI 2');
  // pisz(wsx+130,wsy+5,' TRANSFORMATOR TROqJUZWOJENIOWY ');
  // outtextxy(wsx+220,wsy+15,'eT2');
  // outtextxy(20,119,'110kV');
 // miernik(wsx+50,wsy+20,4,'MW',true);
  // miernik(wsx+50,wsy+44,4,'Mvar',true);
  // miernik(wsx+50,wsy+68,4,'kV',true);
  // lacznik(wsx+110,wsy+78,lon1);
  // lacznik(wsx+64,wsy+110,lon2);
   // line(wsx,wsy+130,wsx+getmaxx div 2,wsy+130);
   // line(wsx,wsy+131,wsx+getmaxx div 2,wsy+131);
   // line(wsx,wsy+138,wsx+getmaxx div 2,wsy+138);
   // line(wsx,wsy+139,wsx+getmaxx div 2,wsy+139);
  // wezel(wsx+45,wsy+131);
  // wezel(wsx+85,wsy+139);
   // sygnal(wsx+45,wsy+165,syg3,false);line(wsx+45,wsy+132,wsx+45,wsy+158);
   // sygnal(wsx+85,wsy+165,syg4,false);line(wsx+85,wsy+140,wsx+85,wsy+158);
  // wezel(wsx+65,wsy+182);line(wsx+45,wsy+182,wsx+85,wsy+182);
   // line(wsx+45,wsy+172,wsx+45,wsy+182);line(wsx+85,wsy+172,wsx+85,wsy+182);
   // sygnal(wsx+65,wsy+205,syg6,true);line(wsx+65,wsy+182,wsx+65,wsy+197);
   // lampka(wsx+30,wsy+200,ls1);
   // stacyjka(wsx+100,wsy+205);
   // miernik(wsx+52,wsy+230,4,'A',true);line(wsx+65,wsy+212,wsx+65,wsy+228);
   // sygnal(wsx+65,wsy+270,syg7,false);line(wsx+65,wsy+252,wsx+65,wsy+263);
  // wezel(wsx+65,wsy+285);line(wsx+65,wsy+277,wsx+65,wsy+319);
   // sygnal(wsx+100,wsy+305,syg8,true);line(wsx+65,wsy+285,wsx+100,wsy+285);line(wsx+100,wsy+285,wsx+100,wsy+297);
   // uziemienie(wsx+100,wsy+312);glowica(wsx+65,wsy+318);
   // lamp_wsk(wsx+130,wsy+285,4);

    // wezel(wsx+285,wsy+131);
    // wezel(wsx+245,wsy+139);
   // sygnal(wsx+285,wsy+165,syg12,false);line(wsx+285,wsy+132,wsx+285,wsy+158);
   // sygnal(wsx+245,wsy+165,syg11,false);line(wsx+245,wsy+140,wsx+245,wsy+158);
  // wezel(wsx+265,wsy+182);line(wsx+285,wsy+182,wsx+245,wsy+182);
   // line(wsx+285,wsy+172,wsx+285,wsy+182);line(wsx+245,wsy+172,wsx+245,wsy+182);
   // sygnal(wsx+265,wsy+205,syg14,true);line(wsx+265,wsy+182,wsx+265,wsy+197);
   // lampka(wsx+230,wsy+200,ls2);
   // miernik(wsx+252,wsy+230,4,'A',true);line(wsx+265,wsy+212,wsx+265,wsy+228);
   // trafo(wsx+265,wsy+260,true);line(wsx+265,wsy+252,wsx+265,wsy+260);
   // line(wsx+235,wsy+295,wsx+235,wsy+305);line(wsx+295,wsy+295,wsx+295,wsy+305);
   // sygnal(wsx+235,wsy+314,syg9,true);sygnal(wsx+295,wsy+314,syg10,true);
   // line(wsx+235,wsy+323,wsx+235,wsy+335);wezel(wsx+235,wsy+335);
   // line(wsx+295,wsy+323,wsx+295,wsy+335);wezel(wsx+295,wsy+335);
   // line(wsx+275,wsy+335,wsx+315,wsy+335);line(wsx+275,wsy+336,wsx+315,wsy+336);
   // line(wsx+215,wsy+335,wsx+255,wsy+335);line(wsx+215,wsy+336,wsx+255,wsy+336);
    // settextstyle(smallfont,horizdir,4);
    // outtextxy(wsx+205,wsy+323,'6kV');outtextxy(wsx+265,wsy+323,'15kV');
    // outtextxy(wsx+30,wsy+210,'13');outtextxy(wsx+231,wsy+210,'30');
    // outtextxy(wsx+120,wsy+195,'LSy');outtextxy(wsx+210,wsy+195,'LS');
    // outtextxy(wsx+104,wsy+87,'48');outtextxy(wsx+60,wsy+119,'12');
    // outtextxy(wsx+280,wsy+119,'110kV');outtextxy(wsx+85,wsy+60,'LV');
    // outtextxy(wsx+10,wsy+195,'LS');
   // lamp_wsk(wsx+180,wsy+285,4);end;
// {=================================================================================}
// procedure pol_pom4 {PROCEDURARYSUJACA POLE POOMIAROWE  NR 8}
// (wsx,wsy,polw,lon1,lon2,lon3,syg1,syg2,syg3,syg4,syg5,syg6,syg7,syg8,syg9:integer;syg10:boolean);
// var kat:word;
 // begin
   // setcolor(3);
   // settextstyle(smallfont,horizdir,4);
   // pisz(wsx+60,wsy+5,'TRANSFORMATOR TROqJUZWOJENIOWY eT1');
   // outtextxy(20,119,'110kV');
   // line(wsx,wsy+130,wsx+getmaxx div 2,wsy+130);
   // line(wsx,wsy+131,wsx+getmaxx div 2,wsy+131);
   // line(wsx,wsy+138,wsx+getmaxx div 2,wsy+138);
   // line(wsx,wsy+139,wsx+getmaxx div 2,wsy+139);
   // sygnal(wsx+50,wsy+165,syg1,false);line(wsx+50,wsy+132,wsx+50,wsy+158);wezel(wsx+50,wsy+131);
   // sygnal(wsx+90,wsy+165,syg2,false);line(wsx+90,wsy+140,wsx+90,wsy+158);wezel(wsx+90,wsy+139);
  // wezel(wsx+70,wsy+182);line(wsx+50,wsy+182,wsx+90,wsy+182);
   // line(wsx+50,wsy+172,wsx+50,wsy+182);line(wsx+90,wsy+172,wsx+90,wsy+182);
   // sygnal(wsx+70,wsy+205,syg3,true);line(wsx+70,wsy+182,wsx+70,wsy+197);
   // lampka(wsx+35,wsy+200,syg10);outtextxy(wsx+20,wsy+200,'LS');outtextxy(wsx+36,wsy+211,'30');
   // miernik(wsx+57,wsy+230,4,'A',true);line(wsx+70,wsy+212,wsx+70,wsy+228);
   // trafo(wsx+70,wsy+260,true);line(wsx+70,wsy+252,wsx+70,wsy+260);
   // line(wsx+40,wsy+295,wsx+40,wsy+305);line(wsx+100,wsy+295,wsx+100,wsy+305);
   // sygnal(wsx+40,wsy+314,syg4,true);sygnal(wsx+100,wsy+314,syg5,true);
   // line(wsx+40,wsy+323,wsx+40,wsy+335);wezel(wsx+40,wsy+335);
   // line(wsx+100,wsy+323,wsx+100,wsy+335);wezel(wsx+100,wsy+335);
   // line(wsx+80,wsy+335,wsx+120,wsy+335);line(wsx+80,wsy+336,wsx+120,wsy+336);
   // line(wsx+20,wsy+335,wsx+60,wsy+335);line(wsx+20,wsy+336,wsx+60,wsy+336);
   // outtextxy(wsx+107,wsy+322,'15kV');outtextxy(wsx+15,wsy+322,'6kV');

    // wezel(wsx+170,wsy+131);
    // wezel(wsx+210,wsy+139);
   // sygnal(wsx+170,wsy+165,syg6,false);line(wsx+170,wsy+132,wsx+170,wsy+158);
   // sygnal(wsx+210,wsy+165,syg7,false);line(wsx+210,wsy+140,wsx+210,wsy+158);
   // przeklad(wsx+170,wsy+220);line(wsx+170,wsy+173,wsx+170,wsy+220);
   // przeklad(wsx+210,wsy+220);line(wsx+210,wsy+173,wsx+210,wsy+220);
   // wezel(wsx+170,wsy+150);wezel(wsx+210,wsy+150);
   // line(wsx+210,wsy+150,wsx+235,wsy+150);line(wsx+235,wsy+150,wsx+235,wsy+178);
   // sygnal(wsx+235,wsy+185,syg8,true); uziemienie(wsx+235,wsy+194);
   // line(wsx+170,wsy+150,wsx+145,wsy+150);line(wsx+145,wsy+150,wsx+145,wsy+178);
   // sygnal(wsx+145,wsy+185,syg9,true);uziemienie(wsx+145,wsy+195);
   // lacznik(wsx+170,wsy+260,lon1);lacznik(wsx+210,wsy+260,lon2);
   // outtextxy(wsx+143,wsy+240,'LV1');outtextxy(wsx+186,wsy+240,'LV2');
   // miernik(wsx+180,wsy+20,4,'kV',true);
   // miernik(wsx+180,wsy+42,4,'kV',true);
   // miernik(wsx+180,wsy+64,4,'Hz',true);
   // lacznik(wsx+70,wsy+100,lon3);
   // outtextxy(wsx+42,wsy+83,'LZ');outtextxy(wsx+65,wsy+110,'53');
   // rectangle(wsx+163,wsy+275,wsx+178,wsy+282);
   // rectangle(wsx+183,wsy+275,wsx+198,wsy+282);
   // rectangle(wsx+203,wsy+275,wsx+218,wsy+282);
   // outtextxy(wsx+169,wsy+272,'1');
   // outtextxy(wsx+189,wsy+272,'2');
   // outtextxy(wsx+209,wsy+272,'3');
    // rectangle(wsx+180,wsy+290,wsx+201,wsy+300);
  // case polw of
    // 0:begin
  // setcolor(0);
   // kat:=315;line(wsx+188,wsy+285,wsx+183,wsy+292);line(wsx+192,wsy+287,wsx+183,wsy+292);
     // arc(wsx+191,wsy+285,kat,kat+180,3);
   // kat:=45;line(wsx+190,wsy+297,wsx+199,wsy+302);line(wsx+194,wsy+295,wsx+199,wsy+302);
     // arc(wsx+191,wsy+295,kat,kat+180,3);
  // setcolor(3);
    // rectangle(wsx+180,wsy+290,wsx+201,wsy+300);
    // kat:=0;line(wsx+188,wsy+296,wsx+191,wsy+303);line(wsx+194,wsy+296,wsx+191,wsy+303);
     // arc(wsx+191,wsy+295,kat,kat+180,3);end;
   // 1:begin
  // setcolor(0);
   // kat:=0;line(wsx+188,wsy+296,wsx+191,wsy+303);line(wsx+194,wsy+296,wsx+191,wsy+303);
     // arc(wsx+191,wsy+295,kat,kat+180,3);
   // kat:=45;line(wsx+190,wsy+297,wsx+199,wsy+302);line(wsx+194,wsy+295,wsx+199,wsy+302);
     // arc(wsx+191,wsy+295,kat,kat+180,3);
   // setcolor(3);
   // rectangle(wsx+180,wsy+290,wsx+201,wsy+300);
   // kat:=315;line(wsx+188,wsy+295,wsx+183,wsy+302);line(wsx+192,wsy+297,wsx+183,wsy+302);
     // arc(wsx+191,wsy+295,kat,kat+180,3);
     // end;
   // 2:begin setcolor(0);
     // kat:=0;line(wsx+188,wsy+296,wsx+191,wsy+303);
   // line(wsx+194,wsy+296,wsx+191,wsy+303);
     // arc(wsx+191,wsy+295,kat,kat+180,3);
    // kat:=315;line(wsx+188,wsy+295,wsx+183,wsy+302);line(wsx+192,wsy+297,wsx+183,wsy+302);
     // arc(wsx+191,wsy+295,kat,kat+180,3);
   // setcolor(3);kat:=45;line(wsx+190,wsy+297,wsx+199,wsy+302);line(wsx+194,wsy+295,wsx+199,wsy+302);
     // arc(wsx+191,wsy+295,kat,kat+180,3);rectangle(wsx+180,wsy+290,wsx+201,wsy+300)end;
  // end;
  // outtextxy(wsx+157,wsy+287,'LHz');
   // end;
// {=================================================================================}
// procedure pol_pom5       {PROCEDURA RYSUJACA POLE POMIAROWE NR 10, POLE GENERATORA I }
// (wsx,wsy,syg1,syg2,syg3,syg5,syg6,syg7,syg8:integer;ls4:boolean;numgener:string);
// var a:integer;
// begin
   // setcolor(3);
   // settextstyle(smallfont,horizdir,4);
   // outtextxy(wsx+140,wsy+15,numgener);
   // outtextxy(20,109,'110kV');
   // line(wsx,wsy+130,wsx+getmaxx div 2,wsy+130);
   // line(wsx,wsy+131,wsx+getmaxx div 2,wsy+131);
   // line(wsx,wsy+138,wsx+getmaxx div 2,wsy+138);
   // line(wsx,wsy+139,wsx+getmaxx div 2,wsy+139);
   // sygnal(wsx+140,wsy+160,syg1,true);line(wsx+140,wsy+132,wsx+140,wsy+153);wezel(wsx+140,wsy+131);
   // sygnal(wsx+180,wsy+160,syg2,true);line(wsx+180,wsy+140,wsx+180,wsy+153);wezel(wsx+180,wsy+139);
   // wezel(wsx+160,wsy+177);line(wsx+140,wsy+177,wsx+180,wsy+177);
   // line(wsx+140,wsy+167,wsx+140,wsy+177);line(wsx+180,wsy+167,wsx+180,wsy+177);
   // sygnal(wsx+160,wsy+198,syg3,true);line(wsx+160,wsy+177,wsx+160,wsy+190);
   // lampka(wsx+125,wsy+192,ls4);outtextxy(wsx+110,wsy+191,'LS');outtextxy(wsx+126,wsy+205,'67');
   // line(wsx+160,wsy+207,wsx+160,wsy+218);trafo(wsx+160,wsy+211,false);
   // line(wsx+160,wsy+242,wsx+160,wsy+251);
   // miernik(wsx+150,wsy+251,3,'A',false);
   // miernik(wsx+129,wsy+251,3,'A',false);
   // miernik(wsx+171,wsy+251,3,'A',false);
   // line(wsx+160,wsy+271,wsx+160,wsy+284);
   // circle(wsx+160,wsy+292,10);
   // line(wsx+160,wsy+300,wsx+160,wsy+310);wezel(wsx+160,wsy+310);
   // line(wsx+130,wsy+310,wsx+190,wsy+310);line(wsx+130,wsy+310,wsx+130,wsy+320);line(wsx+190,wsy+310,wsx+190,wsy+320);
   // sygnal(wsx+130,wsy+329,syg7,true);sygnal(wsx+190,wsy+329,syg8,true);
   // line(wsx+130,wsy+335,wsx+130,wsy+345);line(wsx+190,wsy+335,wsx+190,wsy+345);
   // circle(wsx+130,wsy+352,10);circle(wsx+190,wsy+352,10);
  // outtextxy(wsx+158,wsy+286,'G');outtextxy(wsx+125,wsy+346,'WR');outtextxy(wsx+185,wsy+346,'WG');
  // miernik(wsx+30,wsy+30,4,'A',true);
  // miernik(wsx+30,wsy+78,4,'GrV',true);
  // miernik(wsx+240,wsy+30,4,'A',true);
  // miernik(wsx+240,wsy+78,4,'GrV',true);
  // miernik(wsx+147,wsy+30,4,'MW',true);
  // miernik(wsx+147,wsy+54,4,'Mvar',true);
  // miernik(wsx+147,wsy+78,4,'kV',true);
  // miernik(wsx+40,wsy+182,4,'EA',true);
  // miernik(wsx+240,wsy+182,4,'EA',true);
   // line(wsx+172,wsy+225,wsx+230,wsy+225);line(wsx+230,wsy+225,wsx+230,wsy+235);
   // sygnal(wsx+230,wsy+243,syg5,true);uziemienie(wsx+230,wsy+252);
   // wezel(wsx+160,wsy+246);line(wsx+160,wsy+246,wsx+70,wsy+246);line(wsx+70,wsy+246,wsx+70,wsy+255);
   // trafo(wsx+70,wsy+248,false);line(wsx+70,wsy+280,wsx+70,wsy+290);
   // sygnal(wsx+70,wsy+298,syg6,true);line(wsx+70,wsy+306,wsx+70,wsy+320);
   // wezel(wsx+70,wsy+320);line(wsx+50,wsy+320,wsx+90,wsy+320);line(wsx+50,wsy+321,wsx+90,wsy+321);
   // outtextxy(wsx+48,wsy+308,'6kV');
// end;
// {=================================================================================}
// procedure pol_pom6  {PROCEDURA RYSUJACA POLE POMIAROWE NR 9}
// (wsx,wsy,syg1,syg2,syg3,lon1:integer;ls1:boolean);
// begin
   // setcolor(3);
   // settextstyle(smallfont,horizdir,4);
   // pisz(wsx+130,wsy+5,'SPRZEaGLlO');
   // outtextxy(20,119,'110kV');
   // line(wsx,wsy+130,wsx+getmaxx div 2,wsy+130);
   // line(wsx,wsy+131,wsx+getmaxx div 2,wsy+131);
   // line(wsx,wsy+138,wsx+getmaxx div 2,wsy+138);
   // line(wsx,wsy+139,wsx+getmaxx div 2,wsy+139);
  // wezel(wsx+50,wsy+131);
  // wezel(wsx+90,wsy+139);
  // miernik(wsx+55,wsy+20,4,'MW',true);
  // miernik(wsx+55,wsy+44,4,'Mvar',true);
  // miernik(wsx+55,wsy+68,4,'kV',true);
  // lacznik(wsx+69,wsy+110,lon1);outtextxy(wsx+85,wsy+93,'LV');
  // sygnal(wsx+50,wsy+165,syg3,true);line(wsx+50,wsy+132,wsx+50,wsy+197);
   // sygnal(wsx+90,wsy+165,syg2,true);line(wsx+90,wsy+140,wsx+90,wsy+158);
   // line(wsx+90,wsy+172,wsx+90,wsy+228);
   // sygnal(wsx+50,wsy+205,syg1,true);
   // lampka(wsx+20,wsy+200,ls1);outtextxy(wsx+20,wsy+185,'LS');outtextxy(wsx+20,wsy+210,'12');
   // miernik(wsx+77,wsy+230,4,'A',true);
   // line(wsx+50,wsy+213,wsx+50,wsy+280);
   // line(wsx+90,wsy+253,wsx+90,wsy+280);
   // line(wsx+50,wsy+280,wsx+90,wsy+280);
   // lamp_wsk(wsx+100,wsy+285,11);
// end;
// {=======================================================================================}
// procedure pol_pom7
// (wsx,wsy,lon1,lon2,syg1,syg2,syg3,syg4,syg5:integer;syg6:boolean);
// begin
  // settextstyle(smallfont,horizdir,4);outtextxy(wsx+130,wsy+5,'MORZYCZYN');
   // line(wsx,wsy+130,wsx+getmaxx div 2,wsy+130);
   // line(wsx,wsy+131,wsx+getmaxx div 2,wsy+131);
   // line(wsx,wsy+138,wsx+getmaxx div 2,wsy+138);
   // line(wsx,wsy+139,wsx+getmaxx div 2,wsy+139);
   // miernik(wsx+220,wsy+20,4,'MW',true);
  // miernik(wsx+220,wsy+44,4,'Mvar',true);
  // miernik(wsx+220,wsy+68,4,'kV',true);
  // lacznik(wsx+190,wsy+78,lon1);outtextxy(wsx+170,wsy+58,'LS');outtextxy(wsx+185,wsy+88,'20');
  // lacznik(wsx+235,wsy+110,lon2);outtextxy(wsx+212,wsy+93,'LS');outtextxy(wsx+230,wsy+119,'12');
    // wezel(wsx+255,wsy+131);
    // wezel(wsx+215,wsy+139);
   // sygnal(wsx+255,wsy+165,syg1,true);line(wsx+255,wsy+132,wsx+255,wsy+158);
   // sygnal(wsx+215,wsy+165,syg2,true);line(wsx+215,wsy+140,wsx+215,wsy+158);
  // wezel(wsx+235,wsy+182);line(wsx+256,wsy+182,wsx+215,wsy+182);
   // line(wsx+255,wsy+172,wsx+255,wsy+182);line(wsx+215,wsy+172,wsx+215,wsy+182);
   // sygnal(wsx+235,wsy+205,syg3,true);line(wsx+235,wsy+182,wsx+235,wsy+197);
   // lampka(wsx+200,wsy+200,syg6);outtextxy(wsx+180,wsy+200,'LS');outtextxy(wsx+201,wsy+211,'13');
   // stacyjka(wsx+270,wsy+205);outtextxy(wsx+285,wsy+193,'LSy');
   // miernik(wsx+222,wsy+230,4,'A',true);line(wsx+235,wsy+212,wsx+235,wsy+228);
   // sygnal(wsx+235,wsy+270,syg4,true);line(wsx+235,wsy+252,wsx+235,wsy+263);
 // wezel(wsx+235,wsy+285);line(wsx+235,wsy+277,wsx+235,wsy+319);
   // sygnal(wsx+260,wsy+305,syg5,true);line(wsx+235,wsy+285,wsx+260,wsy+285);line(wsx+260,wsy+285,wsx+260,wsy+297);
   // uziemienie(wsx+260,wsy+312);glowica(wsx+235,wsy+318);
    // lamp_wsk(wsx+180,wsy+285,4);
 // end;

// procedure trafoet2(wlacz,ktoral:integer;lampw:boolean);
// begin
    // setcolor(3);
    // settextstyle(smallfont,horizdir,4);
    // pisz(130,5,' TRANSFORMATOR TROqJUZWOJENIOWY ');
    // outtextxy(220,15,'eT2');
    // line(0,130,getmaxx div 2,130);
   // line(0,131,getmaxx div 2,131);
   // line(0,138,getmaxx div 2,138);
   // line(0,139,getmaxx div 2,139);
    // wezel(285,131);
    // wezel(245,139);
   // sygnal(285,165,0,false);line(285,132,285,158);
   // sygnal(245,165,1,false);line(245,140,245,158);
  // wezel(265,182);line(285,182,245,182);
   // line(285,172,285,182);line(245,172,245,182);
   // sygnal(265,205,wlacz,true);line(265,182,265,197);
   // lampka(230,200,lampw);
   // miernik(252,230,4,'A',true);line(265,212,265,228);
   // trafo(265,260,true);line(265,252,265,260);
   // line(235,295,235,305);line(295,295,295,305);
   // sygnal(235,314,0,true);sygnal(295,314,1,true);
   // line(235,323,235,335);wezel(235,335);
   // line(295,323,295,335);wezel(295,335);
   // line(275,335,315,335);line(275,336,315,336);
   // line(215,335,255,335);line(215,336,255,336);
    // settextstyle(smallfont,horizdir,4);
    // outtextxy(205,323,'6kV');outtextxy(265,323,'15kV');
    // outtextxy(231,210,'30');
    // outtextxy(210,195,'LS');
    // outtextxy(280,119,'110kV');
    // lamp_wsk(180,285,ktoral);
   // end;

// procedure trafoet1(sygn:integer);
// begin
  // setcolor(3);
  // pisz(400,5,' TRANSFORMATOR TROqJUZWOJENIOWY ');
  // outtextxy(490,15,'eT1');
   // line(320,130,getmaxx,130);
   // line(320,131,getmaxx,131);
   // line(320,138,getmaxx,138);
   // line(320,139,getmaxx,139);
    // wezel(605,131);
    // wezel(565,139);
   // sygnal(605,165,1,false);line(605,132,605,158);
   // sygnal(565,165,0,false);line(565,140,565,158);
  // wezel(585,182);line(605,182,565,182);
   // line(605,172,605,182);line(565,172,565,182);
   // sygnal(585,205,1,true);line(585,182,585,197);
   // lampka(550,200,false);
   // miernik(572,230,4,'A',true);line(585,212,585,228);
   // trafo(585,260,true);line(585,252,585,260);
   // line(555,295,555,305);line(615,295,615,305);
   // sygnal(555,314,1,true);sygnal(615,314,sygn,true);
   // line(555,323,555,335);wezel(555,335);
   // line(615,323,615,335);wezel(615,335);
   // line(595,335,635,335);line(595,336,635,336);
   // line(535,335,575,335);line(535,336,575,336);
    // settextstyle(smallfont,horizdir,4);
    // outtextxy(525,323,'6kV');outtextxy(585,323,'15kV');
    // outtextxy(551,210,'30');
    // outtextxy(530,195,'LS');
    // outtextxy(600,119,'110kV');
    // lamp_wsk(500,285,10);
// end;

// procedure ekran2;
// begin
// if nrekranu<>2 then begin
// clearviewport;
// pol_pom5(0,-10,1,0,1,0,1,1,1,false,'GENERATOR I');
// pol_pom5(320,-10,0,1,1,0,1,0,1,false,'GENERATOR II');
// line (getmaxx div 2,0,getmaxx div 2,getmaxy);outtextxy(20,109,'110kV');end;
// nrekranu:=2;
// end;

// procedure ekran1;
// begin
// if nrekranu<>1 then begin
// clearviewport;
// pol_pom4(0,0,0,0,0,0,1,0,1,1,0,1,1,0,0,false);
// pol_pom1(320,0,1,1,0,1,1,1,0,5,false);
// line (getmaxx div 2,0,getmaxx div 2,getmaxy);outtextxy(20,119,'110kV');end;
// nrekranu:=1;
// end;

// procedure ekran3;
// begin
// if nrekranu<>3 then begin
// clearviewport;
// pol_pom2(0,0,1,0,1,0,1,1,1,0,1,1,1,0,1,0,false,false);
// pol_pom3(320,0,0,1,0,1,1,1,0,0,1,1,0,1,false,false);

// line (getmaxx div 2,0,getmaxx div 2,getmaxy);outtextxy(20,119,'110kV');END;
// nrekranu:=3;
// end;

// procedure ekran4;
// begin
// if nrekranu<>4 then begin
// clearviewport;
// pol_pom6(0,0,1,1,1,1,false);
// pol_pom7(320,0,1,1,0,1,1,1,0,false);
// line (getmaxx div 2,0,getmaxx div 2,getmaxy);outtextxy(20,119,'110kV');END;
// nrekranu:=4;
// end;

// procedure spr_klaw;
// var a:char;
// begin
// a:=readkey;
 // case a of
 // '1':ekran1;
 // '2':ekran2;
 // '3':ekran3;
 // '4':ekran4;
 // end;
// end;

// procedure obwodka(prx1,pry1,prx2,pry2,color:integer);
// var  p:pointer;
  // size:word;
 // begin
  // size:=imagesize(prx1,pry1,prx2,pry2);
  // getmem(p,size);
  // getimage(prx1,pry1,prx2,pry2,p^);
  // setfillstyle(1,color);
  // bar(prx1,pry1,prx2,pry2);
  // setcolor(15);
  // putimage(prx1,pry1,p^,andput);
  // freemem(p,size);
  // end;

// procedure obwodka1(prx1,pry1,prx2,pry2,color:integer);
// var  p:pointer;
  // size:word;
 // begin
  // setfillstyle(1,color);
  // bar(prx1,pry1,prx2,pry2);
  // setcolor(15);
  // end;

// procedure strzal(wsx,wsy:integer);
// begin
// line(wsx,wsy,wsx,wsy+6);
// line(wsx-3,wsy+3,wsx,wsy);
// line(wsx+3,wsy+3,wsx,wsy);
// line(wsx+10,wsy,wsx+10,wsy+6);
// line(wsx+7,wsy+3,wsx+10,wsy+6);
// line(wsx+13,wsy+3,wsx+10,wsy+6);
// end;
// procedure delta(wsx,wsy:integer);
// begin
// line(wsx,wsy,wsx+9,wsy);
// line(wsx,wsy,wsx+5,wsy-5);
// line(wsx+5,wsy-5,wsx+10,wsy);
// end;
// procedure ram(wsx,wsy:integer);
// begin
// line(wsx,wsy,wsx+44,wsy);line(wsx+2,wsy+2,wsx+42,wsy+2);
// line(wsx+44,wsy,wsx+44,wsy+79);line(wsx+42,wsy+2,wsx+42,wsy+77);
// line(wsx,wsy,wsx,wsy+79);line(wsx+2,wsy+2,wsx+2,wsy+77);
// line(wsx,wsy+79,wsx+44,wsy+79);line(wsx+2,wsy+77,wsx+42,wsy+77);
// line(wsx+22,wsy+2,wsx+22,wsy+77);
// for a:=0 to 3 do begin
// line(wsx+2,wsy+17+a*15,wsx+42,wsy+17+a*15);end;
// settextstyle(defaultfont,horizdir,1);
// delta(wsx+8,wsy+12);outtextxy(wsx+29,wsy+7,'D');
// outtextxy(wsx+9,wsy+22,'2');outtextxy(wsx+29,wsy+22,'R');
// outtextxy(wsx+9,wsy+37,'3');outtextxy(wsx+29,wsy+37,'S');
// outtextxy(wsx+9,wsy+52,'W');outtextxy(wsx+29,wsy+52,'T');
// outtextxy(wsx+9,wsy+67,'H');outtextxy(wsx+29,wsy+67,'E');
// end;
// procedure ryspol1;
// begin
 // pol_pom1(0,0,1,1,0,1,1,1,0,6,true);
 // setfillstyle(0,0);
 // bar (320,0,getmaxx,getmaxy);
 // setcolor(15);
// end;
// procedure zespollampek;
// begin
   // pisz(350,10,'ZESPOqLl LAMPEK SYNALIZUJAaCYCH STANY');
   // pisz(350,20,'AWARYJNE NA LINII');
   // delta(360,49);pisz(375,40,'-SYGNALIZACJA ZWARCIA MIEDZYFAZOWEGO ;');
   // pisz(363,55,'2 - SYGNALIZACJA ZADZIALlANIA DRUGIEGO STOPNIA');
   // pisz(380,66,'ZABEZPIECZENq ODLEGLlOSqCIOWYCH;');
   // pisz(363,80,'3 -SYGNALIZACJA ZADZIALlANIA TRZECIEGO STOPNIA ');
   // pisz(380,91,'ZABEZPIECZENq ODLEGLlOSqCIOWYCH ;');
   // pisz(360,105,'W,H -SYGNALIZACJA USZKODZENIA SYSTEMU ');
   // pisz(380,116,'TELEFONII NOSqNEJ;');
   // pisz(363,130,'D -SYGNALIZACJA ZWARCIA KTOREJSq Z FAZ DO ZIEMI;');
   // pisz(363,145,'R -SYGNALIZACJA WYSTAaPIENIA ZWARCIA Z FAZAa R ;');
   // pisz(363,160,'S -SYGNALIZACJA WYSTAaPIENIA ZWARCIA Z FAZAa S ;');
   // pisz(363,175,'T -SYGNALIZACJA WYSTAaPIENIA ZWARCIA Z FAZAa T ;');
   // pisz(363,190,'E -SYGNALIZACJA WYSTAaPIENIA NIEUDANEGO');
   // pisz(380,200,'CYKLU SPZ ;');
   // ram(350,260);
// end;

// procedure demo1;
// var a,z,x:word;b,s:char;k:boolean;
// begin
// if a <> 1 then begin
// clearviewport;z:=11;k:=false;
// setcolor(3);pol_pom1(0,0,1,1,0,1,1,1,0,7,true);
// setcolor(15);outtextxy(350,50,'W CELU UZYSKANIA INFORMACJI NA TEMAT POLA');
// pisz(350,62,'POMIAROWEGO UZzYJ KLAWISZY');strzal(510,63);
// outtextxy(350,74,'LUB ENTER DLA KONTYNUACJI');
// repeat
// b:=readkey;
// if ord(b)<>0 then begin
// if k=true then z:=x;
// if b=#72 then begin z:=z-1;x:=z;k:=false;end;
// if b=#80 then begin z:=z+1;x:=z;k:=false;end;
// if b<>#80 then begin
// if b<>#72 then begin z:=50+z;k:=true;end;end;
// if z=100 then z:=50;
// if z=0 then z:=11;
// if z=12 then z:=1;
// if z=1 then begin;
   // ryspol1;obwodka(48,14,89,95,cr1);
   // pisz(350,20,'MIERNIKI PARAMETROqW ENERGII PRZEPLlYWAJAaCEJ');
   // pisz(350,30,'PRZEZ TO POLE POMIAROWE');
   // end;
// if z=2 then begin;
   // ryspol1;obwodka(88,63,131,97,cr1);
   // pisz(370,64,'PRZELlAaCZNIK WOLTOMIERZOWY');
   // END;
// if z=3 then begin;
   // ryspol1;obwodka(50,96,87,128,cr1);
   // pisz(360,96,'LlAaCZNIK WYLlAaCZAJAaCY AUTOMATYKEa SPZ');
   // END;
// if z=4 then begin;
   // ryspol1;obwodka(38,159,63,171,cr1);obwodka(78,159,103,171,cr1);
   // pisz(360,156,'SYGNALIZATORY POLOZzENIA STYKOqW ODLlAaCZNIKOqW');
   // pisz(360,166,'ZAPEWNIAJAaCYCH PRACEa W I LUB II SYSTEMIE SZYN');
   // end;
// if z=5 then begin;
   // ryspol1;obwodka(56,198,84,212,cr1);
   // pisz(380,195,'WYLlAaCZNIK GLOqWNY TEGO POLA');
   // end;
// if z=6 then begin;
   // ryspol1;obwodka(91,195,136,215,cr1);
   // pisz(380,195,'STACYJKA BLOKUJAaCA REaCZNE URUCHOMIENIE');
   // pisz(380,205,'NAPEaDU WYLlAaCZNIKA');
   // END;
// if z=7 then begin;
   // ryspol1;obwodka(10,195,54,219,cr1);
   // pisz(380,195,'LAMPKA SYGNALIZUJAaCA UZBRAJANIE');
   // pisz(380,205,'NAPEaDU WYLlAaCZNIKA');
   // END;
// if z=8 then begin;
   // ryspol1;obwodka(50,228,91,252,cr1);
   // pisz(380,225,'MIERNIK PRAaDU PRZESYLlANEGO PRZEZ TO POLE');
   // END;
// if z=9 then begin;
   // ryspol1;obwodka(58,264,82,276,cr1);
   // pisz(380,262,'ODLlAaCZNIK ODCINAJAaCY LINIEa');
   // end;
// if z=10 then begin;
   // ryspol1;obwodka(90,298,120,312,cr1);
   // pisz(380,295,'WYLlAaCZNIK UZIEMIAJAaCY LINIEa');
   // END;
// if z=11 then begin;
   // ryspol1;obwodka(143,280,180,323,cr1);
   // zespollampek
   // END;
// end;
   // until (b=#13) or (b=#27);
   // if b=#27 then uciec:=1;

// end;a:=1;end;
// {=================================================================================}
// procedure ryspol2;
// begin
// pol_pom3(0,0,0,1,0,1,1,1,0,1,0,1,0,1,true,true);
 // setfillstyle(0,0);
 // bar (320,0,getmaxx,getmaxy);
 // setcolor(15);
// end;
// procedure demo2;
// var a,z,x:word;b,s:char;k:boolean;
// begin
// if a <> 2 then begin
// clearviewport;z:=18;k:=false;
// pol_pom3(0,0,0,1,0,1,1,1,0,1,0,1,0,1,true,true);
// setcolor(15);pisz(350,50,'W CELU UZYSKANIA INFORMACJI NA TEMAT POLA');
// pisz(350,62,'POMIAROWEGO UZzYJ KLAWISZY');strzal(510,63);
// pisz(350,74,'LUB ENTER DLA KONTYNUACJI');
// repeat
// b:=readkey;
// if ord(b)<>0 then begin
// if k=true then z:=x;
// if b=#72 then begin z:=z-1;x:=z;k:=false;end;
// if b=#80 then begin z:=z+1;x:=z;k:=false;end;
// if b<>#80 then begin
// if b<>#72 then begin z:=50+z;k:=true;end;end;
// if z=100 then z:=50;
// if z=0 then z:=18;
// if z=19 then z:=1;
// if z=1 then begin;
   // ryspol2;obwodka(44,14,83,95,cr1);
   // pisz(350,20,'MIERNIKI PARAMETROqW ENERGII PRZEPLlYWAJAaCEJ');
   // pisz(350,30,'PRZEZ TO POLE POMIAROWE');
   // end;
// if z=2 then begin;
   // ryspol2;obwodka(84,63,137,97,cr1);
   // pisz(370,64,'PRZELlAaCZNIK WOLTOMIERZOWY');
   // END;
// if z=3 then begin;
   // ryspol2;obwodka(50,96,87,128,cr1);
   // pisz(360,96,'LlAaCZNIK WYLlAaCZAJAaCY AUTOMATYKEa SPZ');
   // END;
// if z=4 then begin;
   // ryspol2;obwodka(34,159,59,171,cr1);obwodka(74,159,99,171,cr1);
   // pisz(380,156,'SYGNALIZATORY POLlOZzENIA STYKOqW ODLlAaCZNIKOqW');
   // pisz(380,166,'ZAPEWNIAJAaCYH PRACEa W I LUB II SYSTEMIE SZYN');
   // end;
// if z=5 then begin;
   // ryspol2;obwodka(52,198,80,212,cr1);
   // pisz(380,195,'WYLlAaCZNIK GLlOqWNY TEGO POLA');
   // end;
// if z=6 then begin;
   // ryspol2;obwodka(90,195,136,215,cr1);
   // pisz(380,195,'STACYJKA BLOKUJAaCA REaCZNE URUCHOMIENIE');
   // pisz(380,205,'NAPEaDU WYLlAaCZNIKA');
   // END;
// if z=7 then begin;
   // ryspol2;obwodka(10,195,54,219,cr1);
   // pisz(380,195,'LAMPKA SYGNALIZUJAaCA UZBRAJANIE');
   // pisz(380,205,'NAPEaDU WYLlAaCZNIKA');
   // END;
// if z=8 then begin;
   // ryspol2;obwodka(50,228,91,252,cr1);
   // pisz(380,225,'MIERNIK PRAaDU PRZESYLlANEGO PRZEZ TO POLE');
   // END;
// if z=9 then begin;
   // ryspol2;obwodka(54,264,78,276,cr1);
   // pisz(380,262,'ODLlAaCZNIK ODCINAJAaCY LINIEa');
   // end;
// if z=10 then begin;
   // ryspol2;obwodka(90,298,120,312,cr1);
   // pisz(380,295,'WYLlAaCZNIK UZIEMIAJAaCY LINIEa');
   // END;
// if z=11 then begin;
   // ryspol2;obwodka(130,280,170,323,cr1);
   // zespollampek;
   // END;
// if z=12 then begin
   // ryspol2;obwodka(270,159,300,171,cr1);obwodka(230,159,260,171,cr1);
   // pisz(360,156,'SYGNALIZATORY POLlOZzENIA STYKOqW ODLlAaCZNIKOqW');
   // pisz(360,166,'ZAPEWNIAJAaCYH PRACEa W I LUB II SYSTEMIE SZYN');
   // end;
// if z=13 then begin;
   // ryspol2;obwodka(250,198,280,212,cr1);
   // pisz(380,195,'WYLlAaCZNIK GLlOqWNY TEGO POLA');
   // end;
// if z=14 then begin;
   // ryspol2;obwodka(200,195,242,219,cr1);
   // pisz(380,195,'LAMPKA SYGNALIZUJAaCA UZBRAJANIE');
   // pisz(380,205,'NAPEaDU WYLlAaCZNIKA');
   // END;
// if z=15 then begin;
   // ryspol2;obwodka(235,228,295,252,cr1);
   // pisz(380,225,'MIERNIK PRAaDU PRZESYLlANEGO PRZEZ TO POLE');
   // END;
// if z=16 then begin
   // ryspol2;obwodka(247,268,283,290,cr1);
   // pisz(380,265,'TRANSFORMATOR TROqJUZWOJENIOWY');
   // end;
// if z=17 then begin
   // ryspol2;obwodka(260,307,308,321,cr1);obwodka(223,307,260,321,cr1);
   // pisz(380,300,'WYLlAaCZNIKI ZASILANIA LINII 6kV i 15kV');
   // end;
// if z=18 then begin
   // ryspol2;obwodka(180,280,220,323,cr1);
   // zespollampek;
   // end;
// end;
   // until (b=#13) or (b=#27);
   // if b=#27 then uciec:=1;

// end;a:=2;end;
// {=================================================================================}
// procedure ryspol3;
// begin
// setcolor(3);pol_pom5(0,-10,1,0,1,0,1,0,0,true,'GENERATOR I');
 // setfillstyle(0,0);
 // bar (320,0,getmaxx,getmaxy);
 // setcolor(15);
// end;
// procedure demo3;
// var a,z,x:word;b,s:char;k:boolean;
// begin
// if a <> 3 then begin
// clearviewport;z:=15;k:=false;
// pol_pom5(0,-10,1,0,1,0,1,0,0,true,'GENERATOR I');
// setcolor(15);pisz(350,50,'W CELU UZYSKANIA INFORMACJI NA TEMAT POLA');
// pisz(350,62,'POMIAROWEGO UZzYJ KLAWISZY');strzal(510,63);
// pisz(350,74,'LUB ENTER DLA KONTYNUACJI');
// repeat
// b:=readkey;
// if ord(b)<>0 then begin
// if k=true then z:=x;
// if b=#72 then begin z:=z-1;x:=z;k:=false;end;
// if b=#80 then begin z:=z+1;x:=z;k:=false;end;
// if b<>#80 then begin
// if b<>#72 then begin z:=50+z;k:=true;end;end;
// if z=100 then z:=50;
// if z=0 then z:=15;
// if z=16 then z:=1;
// if z=1 then begin
   // ryspol3;obwodka(20,14,65,95,cr1);
   // pisz(350,20,'MIERNIK PRAaDU GENERATORA PO STRONIE 110kV');
   // pisz(350,80,'WARTOSqCq NAPIEaCIA WZBUDZENIA PODSTAWOWEGO');
   // end;
// if z=2 then begin
   // ryspol3;obwodka(140,18,190,95,cr1);
   // pisz(350,20,'MIERNIKI PARAMETROqW ENERGII PRZEPLlYWAJAaCEJ');
   // pisz(350,30,'PRZEZ TO POLE POMIAROWE');
   // end;
// if z=3 then begin
   // ryspol3;obwodka(235,18,280,95,cr1);
   // pisz(350,20,'AMPEROMIERZ PRAaDU GENERATORA PO STRONIE 6kV');
   // pisz(350,80,'WOLTOMIERZ KONTROLI KONTAKTU STYKOqW ');
   // pisz(350,91,'PRZEKAZqNIKA TIRILLA');
   // end;
// if z=4 then begin
   // ryspol3;obwodka(130,142,150,158,cr1);obwodka(170,142,200,158,cr1);
   // pisz(350,140,'ODLlAaCZNIKI ZAPEWNIAJAaCE MOZzLIWOSqCq PRACY');
   // pisz(350,151,'W JEDNYM Z DWOqCH SYSTEMOqW SZYN');
   // end;
// if z=5 then begin
   // ryspol3;obwodka(150,180,170,195,cr1);
   // pisz(350,180,'WYLlAaCZNIK GLlOqWNY LINII');
   // END;
// if z=6 then begin
   // ryspol3;obwodka(110,180,145,210,cr1);
   // pisz(350,180,'LAMPKA SYGNALIZUJAaCA UZBRAJANIE');
   // pisz(350,190,'NAPEaDU WYLlAaCZNIKA');
   // END;
// if z=7 then begin
   // ryspol3;obwodka(30,160,75,195,cr1);
   // pisz(350,180,'MIERNIK PRAaDU WZBUDZENIA PODSTAWOWEGO');
   // END;
// if z=8 then begin
   // ryspol3;obwodka(235,160,280,195,cr1);
   // pisz(350,180,'MIERNIK NAPIEaCIA WZBUDZENIA PODSTAWOWEGO');
   // end;
// if z=9 then  begin
   // ryspol3;obwodka(150,209,170,232,cr1);
   // pisz(350,210,'TRANSFORMATOR DOPASOWUJAaCY NAPIEaCIE GENERATORA');
   // pisz(350,220,'DO NAPIEaCIA SIECI');
   // END;
// if z=10 then begin
   // ryspol3;obwodka(220,225,250,240,cr1);
   // pisz(350,230,'WYLlAaCZNIK UZIEMIAJAaCY');
   // END;
// if z=11 then begin
   // ryspol3;obwodka(129,240,200,261,cr1);
   // pisz(350,250,'MIERNIKI PRAaDU TRZECH FAZ GENERATORA');
   // end;
// if z=12 then begin
   // ryspol3;obwodka(60,245,80,269,cr1);OBWODKA(60,281,80,295,cr1);
   // pisz(350,250,'TRANSFORMATOR 6kV WRAZ Z WYLlAaCZNIKIEM LINIOWYM');
   // end;
// if z=13 then begin
   // ryspol3;obwodka(150,275,170,289,cr1);
   // pisz(350,270,'GENERATOR');
   // END;
// if z=14 then begin
   // ryspol3;obwodka(120,312,140,327,cr1);obwodka(120,335,140,350,cr1);
   // pisz(350,300,'WZBUDNICA REZERWOWA WRAZ Z WYLlAaCZNIKIEM');
   // END;
// if z=15 then begin
   // ryspol3;obwodka(180,312,200,327,cr1);obwodka(180,335,200,350,cr1);
   // pisz(350,300,'WZBUDNICA GLlOqWNA WRAZ Z WYLlAaCZNIKIEM');
   // END;
// END;
   // until (b=#13) or (b=#27);
   // if b=#27 then uciec:=1;
// a:=3;
// end;END;
// {=====================================================================================}
// procedure ryspol4;
// begin
// pol_pom4(0,0,0,0,0,0,1,0,1,1,0,1,1,0,0,true);
 // setfillstyle(0,0);
 // bar (320,0,getmaxx,getmaxy);
 // setcolor(15);
// end;

// procedure demo4;
// var a,z,x:word;b,s:char;k:boolean;
// begin
// if a <> 3 then begin
// clearviewport;z:=13;k:=false;
// pol_pom4(0,0,0,0,0,0,1,0,1,1,0,1,1,0,0,true);
// setcolor(15);pisz(350,50,'W CELU UZYSKANIA INFORMACJI NA TEMAT POLA');
// pisz(350,62,'POMIAROWEGO UZzYJ KLAWISZY');strzal(510,63);
// pisz(350,74,'LUB ENTER DLA KONTYNUACJI');
// repeat
// b:=readkey;
// if ord(b)<>0 then begin
// if k=true then z:=x;
// if b=#72 then begin z:=z-1;x:=z;k:=false;end;
// if b=#80 then begin z:=z+1;x:=z;k:=false;end;
// if b<>#80 then begin
// if b<>#72 then begin z:=50+z;k:=true;end;end;
// if z=100 then z:=50;
// if z=0 then z:=13;
// if z=14 then z:=1;
// if z=8 then begin
   // ryspol4;obwodka(178,18,215,90,cr1);
   // pisz(350,20,'MIERNIKI PARAMETROqW ENERGII PRZESYLlANEJ');
   // pisz(350,30,'TYM POLEM');
   // end;
// if z=9 then begin
   // ryspol4;obwodka(160,159,180,172,cr1);obwodka(200,159,220,172,cr1);
   // pisz(350,160,'ODLlAaCZNIKI PRZEKLlADNIKOW NAPIEaCIOWYCH');
   // pisz(360,170,'I i II SYSTEMU');
   // END;
// if z=10 then begin
   // ryspol4;obwodka(130,178,160,192,cr1);obwodka(220,178,250,192,cr1);
   // pisz(350,170,'WYLlAaCZNIKI UZIEMIAJAaCE I i II SYSTEM');
   // END;
// if z=11 then begin
   // ryspol4;obwodka(160,220,180,233,cr1);obwodka(200,220,220,233,cr1);
   // pisz(350,160,'PRZEKLlADNIKI NAPIEaCIOWE I i II SYSTEMU');
   // END;
// if z=12 then begin
   // ryspol4;obwodka(140,240,190,270,cr1);obwodka(180,240,230,270,cr1);
   // pisz(350,250,'LlAaCZNIKI NAPIEaCIOWE I i II SYSTEMU');
   // END;
// if z=13 then begin
   // ryspol4;obwodka(150,272,230,303,cr1);
   // pisz(350,270,'TROqJFAZOWY LlAaCZNIK CZEaSTOTLIWOSqCIOWY');
   // END;
// if z=1 then begin
   // ryspol4;obwodka(40,85,85,120,cr1);
   // pisz(350,90,'LlAaCZNIK ZALlAaCZAJAaCY AUTOMATYKEa SPZ');
   // END;
// if z=2 then begin
   // ryspol4;obwodka(40,159,60,171,cr1);obwodka(80,159,100,171,cr1);
   // pisz(350,160,'ODLlAaCZNIKI LlAaCZAaCE POLE Z JEDNYM Z SYSTEMOqW');
   // END;
// if z=3 then begin
   // ryspol4;obwodka(60,198,80,212,cr1);
   // pisz(350,190,'WYLlAaCZNIK GLlOqWNY POLA');
   // END;
// if z=4  then begin
   // ryspol4;obwodka(20,190,55,220,cr1);
   // pisz(350,180,'LAMPKA SYGNALIZUJAaCA UZBRAJANIE');
   // pisz(350,190,'NAPEaDU WYLlAaCZNIKA');
   // END;
// IF Z=5  THEN BEGIN
   // ryspol4;obwodka(45,228,95,253,cr1);
   // pisz(350,230,'MIERNIK PRAaDU PLlYNAaCEGO PRZEZ POLE');
   // END;
// if z=6 then begin
   // ryspol4;obwodka(52,268,88,290,cr1);
   // pisz(350,265,'TRANSFORMATOR TROqJUZWOJENIOWY');
   // end;
// if z=7 then begin
   // ryspol4;obwodka(30,307,60,322,cr1);obwodka(90,307,110,322,cr1);
   // pisz(350,300,'WYLlAaCZNIKI LINII 6kV i 15 kV');
   // END;
   // end;
   // until (b=#13) or (b=#27);
   // if b=#27 then uciec:=1;
// end;end;

// procedure pokaz;
// begin
// uciec:=0;
// demo1;
// if uciec<>1 then demo2;
// if uciec<>1 then demo3;
// if uciec<>1 then demo4;
// if uciec<>1 then begin
// clearviewport;
// nrekranu:=0;
// pisz(60,60,'NACISKANIE KLAWISZY 1,2,3,4 POZWALA NA OGLAaDANIE CALlYCH POqL');
// pisz(60,72,'NACISqNIEaCIE ENTER LUB Esc SPOWODUJE POWROqT DO MENU');
// repeat
// ch:=readkey;
// if ord(ch)<>0 then begin;
 // case ch of
 // '1':ekran1;
 // '2':ekran2;
 // '3':ekran4;
 // '4':ekran3;
// END; end;
// until (ch=#13) or (ch=#27);
// end;end;

// procedure synchnap;
// var klaw:char;
    // warnap:string;
    // warwol,wartd:byte;
// begin
// randomize;
// wartd:=round(random(20));
// warwol:=wartd+100;
// setcolor(15);pisz(340,188,'USTAWIANIE NAPIEaCIA:');
// pisz(340,200,'KLAWISZE KURSORA    - ZMIANA NAPIEaCIA');strzal(443,202);
// pisz(340,212,'ENTER - PRZEJSqCIE DO DALSZEJ SYCHRONIZACJI ');
// pisz(340,224,'POD WARUNKIEM USTAWIENIA PRAWIDLlOWEGO NAPIEaCIA');
  // str(warwol,warnap);
  // pisz(485,62,warnap);
 // repeat
  // klaw:=readkey;
  // if ord(klaw)<>0 then begin
  // if klaw=#72 then begin warwol:=warwol+1;if warwol=131 then warwol:=130; end;
  // if klaw=#80 then begin warwol:=warwol-1;if warwol=89 then warwol:=90; end;
  // bar(484,63,505,71);
  // str(warwol,warnap);
  // pisz(485,62,warnap);
 // end
  // until (klaw=#13)and(warwol=110);
 // end;

// procedure udana;
// var czek:char;
// begin
// pisz(340,285,'UDANA SYNCHRONIZACJA');czek:=readkey;
// pol_pom5(0,-10,1,0,1,1,0,0,0,true,'GENERATOR I');delay(500);
// pol_pom5(0,-10,1,0,1,1,0,0,0,false,'GENERATOR I');delay(500);
// end;

// procedure czesciowa;
// var czek:char;
// begin
// pisz(340,285,'SYNCHRONIZACJA NIEDOKLlADNA,');
// pisz(340,297,'ISTNIEJE POTRZEBA POWTOqRNEJ SYNCHRONIZACJI');
// czek:=readkey;
// end;

// procedure synchron;
// var kat,szybkosc,cospet,kier:integer;
    // xzew,yzew:longint;
    // radkat:real;
    // koniec:boolean;
    // regs:registers;
    // znak,czek:char;
// const xsyn=495;
      // ysyn=145;
// begin
 // xzew:=465;yzew:=150;szybkosc:=1;kat:=0;koniec:=false;kier:=-1;
 // setfillstyle(0,0);
 // bar (320,0,getmaxx,getmaxy);
 // setcolor(15);
   // miernik(480,62,4,'kV',true);
   // miernik(480,84,4,'Hz',true);
   // synchnap;
   // rectangle(460,120,530,170);
   // rectangle(458,118,532,172);
   // pisz(340,246,'KLAWISZE KURSORA    - ZMIANA CZEaSTOTLIWOSqCI');strzal(444,248);
   // pisz(340,258,'KLAWISZ END - ZAKONqCZENIE SYNCHRONIZACJI');
   // circle(xsyn,ysyn,30);line(465,ysyn,470,ysyn);
   // setwritemode(copyput);
   // repeat
    // kat:=kat+(1*kier);
    // if kat=720 then kat:=0;
    // if kat=-720 then kat:=0;
    // regs.ah:=$0b;
    // intr($21,regs);
   // if regs.al<>0 then begin
    // regs.ah:=$10;
    // intr($16,regs);
    // if regs.ah=72 then szybkosc:=szybkosc+(1*kier);
    // if regs.ah=80 then szybkosc:=szybkosc-(1*kier);
    // if regs.ah=79 then koniec:=true;
    // if szybkosc=0 then szybkosc:=1;
    // if szybkosc=50 then szybkosc:=100;
    // if szybkosc=99 then szybkosc:=49;
    // if szybkosc=101 then kier:=kier*-1
   // end;
   // delay(szybkosc);
   // setcolor(0);
   // line(xsyn,ysyn,xzew,yzew);
   // radkat:=(kat/2)*(pi/180);
   // xzew:=round(xsyn+(20*cos(radkat)));
   // yzew:=round((ysyn+(14*sin(radkat))));
   // setcolor(15);
   // line(xsyn,ysyn,xzew,yzew);
   // until koniec;
   // if ((kat>350)and(kat<370))or((kat<-350)and(kat>-370)) then udana
       // else if((kat>330)and(kat<390))or((kat<-330)and(kat>-390)) then czesciowa
       // else begin pisz(340,285,'NIEUDANA SYNCHRONIZACJA');
         // pisz(340,297,'SPROqBUJ POWTOqRZYCq SYNCHRONIZACJEa');
         // pisz(340,309,'JEDNAK PAMIETAJ ZzE W RZECZYWISTOSqCI');
         // pisz(340,321,'NIE WSZYSTKO DA SIEa POWTOqRZYCq');czek:=readkey;end;
// end;

// procedure beep;
// begin
// sound(1500);
// delay(300);
// bar(18,10,296,90);
// pisz(70,10,'NACISKASZ NIEWLlASqCIWE KLAWISZE');
// pisz(20,22,'UZzYWAJ KLAWISZY KURSORA');strzal(170,25);
// pisz(190,22,'DO PORUSZANIA SIEa');
// pisz(20,36,'KLAWISZEM ENTER POTWIERDZASZ WYBOqR');
// pisz(20,48,'LUB PRZECHODZISZ DO DALSZEJ CZEaSqCI PROGRAMU');
// pisz(20,62,'KLAWISZ Esc WYJSqCIE Z PROGRAMU');
// pisz(20,74,'LUB POWROqT DO GLlOqWNEGO MENU');
// nosound;
// end;


// procedure napis1;
// var p:pointer;
 // size:word;
 // a:char;
// begin
 // delay(500);
 // size:=imagesize(100,100,312,180);
 // getmem(p,size);
 // settextstyle(2,0,4);
 // getimage(100,100,312,180,p^);
 // setfillstyle(1,12);
 // bar(100,100,312,170);
 // setfillstyle(1,7);
 // bar(100,170,312,180);
 // setcolor(0);
 // pisz(110,110,'ZAKLlOqCENIE W SYSTEMIE I');
 // pisz(102,130,'ZADZIALlANIE ZABEZPIECZENq SPRZEaGLlA');
 // pisz(102,141,'ORAZ ZABEZPIECZENq LINIOWYCH SYSTEMU');
 // pisz(102,152,'I GENERATOR I WYPADLl Z SYNCHRONIZMU');setcolor(15);
 // PISZ(110,170,'NACISqNIJ DOWOLNY KLAWISZ');
 // sound(1500);delay(600);nosound;
  // repeat until keypressed;
  // a:=readkey;
 // putimage(100,100,p^,normalput);
 // freemem(p,size);
// end;

// procedure napis2;
// var a:char;
// begin
 // delay(500);
 // settextstyle(2,0,4);
 // setfillstyle(1,1);
 // bar(110,140,310,210);
 // setfillstyle(1,7);
 // bar(110,210,310,223);
 // setcolor(15);
 // pisz(115,145,'CENTRALNA DYSPOZYCJA MOCAa');
 // pisz(115,165,'ZGODA NA PRZEPROWADZENIE');
 // pisz(115,175,'SYNCHRONIZACJI GENERATORA');
 // PISZ(115,185,'60MW DO SIECI 110kV.');
 // PISZ(115,210,'NACISqNIJ DOWOLNY KLAWISZ');
 // repeat until keypressed;
 // a:=readkey;
// end;


// procedure wsk_mier_g1 (wsx,wsy:integer);
// begin
  // pisz(wsx+30,wsy+20,' 1,1');
  // pisz(wsx+28,wsy+68,' 60,2');
  // pisz(wsx+240,wsy+20,' 200');
  // pisz(wsx+240,wsy+68,' 0');
  // pisz(wsx+145,wsy+20,' 40,6');
  // pisz(wsx+145,wsy+44,' 20,4');
  // pisz(wsx+147,wsy+68,' 110');
  // pisz(wsx+40,wsy+172,' 110');
  // pisz(wsx+240,wsy+172,' 1,0');
  // pisz(wsx+146,wsy+241,' 2,5');
  // pisz(wsx+125,wsy+241,' 2,5');
  // pisz(wsx+168,wsy+241,' 2,5');
// end;

// procedure pokaz2;
// begin
// clearviewport;
// pol_pom5(0,-10,1,0,1,1,0,0,0,false,'GENERATOR I');
// pol_pom5(320,-10,0,1,1,1,0,0,0,false,'GENERATOR II');
// napis1;delay(600);
// pol_pom5(0,-10,1,0,0,1,0,0,0,false,'GENERATOR I');delay(500);
// pol_pom5(0,-10,1,0,0,1,0,0,0,true,'GENERATOR I');delay(500);
// pol_pom5(0,-10,1,0,0,1,0,0,0,false,'GENERATOR I');delay(500);
// nrekranu:=0;
// ekran4;
// delay(600);pol_pom6(0,0,0,1,1,1,false);
// pol_pom6(0,0,0,1,1,1,true);delay(1000);
// pol_pom6(0,0,0,1,1,1,false);delay(500);
// NAPIS2;
// delay(1000);
// clearviewport;
// pol_pom5(0,-10,1,0,0,1,0,0,0,false,'GENERATOR I');
// wsk_mier_g1(0,0);
// SYNCHRON;
// end;

// procedure pokaz3;
// var a:char;
// begin
// clearviewport;
// pol_pom1(0,0,1,1,0,1,1,1,0,10,false);pol_pom6(320,0,0,1,1,1,false);
// delay(1500);
// pol_pom1(0,0,1,1,0,1,0,1,0,10,true);
// lamp_wsk(150,285,0);lamp_wsk(150,285,6);lamp_wsk(150,285,7);
// delay(500);
// pol_pom1(0,0,1,1,0,1,0,1,0,10,false);delay(1500);
// pol_pom1(0,0,1,1,0,1,1,1,0,10,true);delay(500);
// pol_pom1(0,0,1,1,0,1,1,1,0,10,false);
// setfillstyle(1,11);
// bar(150,200,300,240);
// setfillstyle(1,15);
// bar(150,240,300,250);
// setcolor(0);
// pisz(155,200,'ZADZIALlANIE SAMOCZYNNEGO');
// pisz(155,211,'POWTOqRNEGO ZALlAaCZENIA.');
// pisz(155,222,'UDANY CYKL SPZ.');
// pisz(155,240,'NACISqNIJ DOWOLNY KLAWISZ');
// delay(1000);
// setcolor(15);
// A:=READKEY;
// end;

// procedure pokaz4;
// var a:char;
// begin
// clearviewport;
// pol_pom1(0,0,1,1,0,1,1,1,0,10,false);pol_pom6(320,0,0,1,1,1,false);delay(1000);
// pol_pom1(0,0,1,1,0,1,0,1,0,10,true);delay(500);
// pol_pom1(0,0,1,1,0,1,0,1,0,10,false);delay(1500);
// pol_pom1(0,0,1,1,0,1,1,1,0,10,true);delay(500);
// pol_pom1(0,0,1,1,0,1,1,1,0,10,false);delay(200);
// pol_pom1(0,0,1,1,0,1,0,1,0,10,true);delay(500);
// pol_pom1(0,0,1,1,0,1,0,1,0,10,false);
// lamp_wsk(150,285,9);
// setfillstyle(1,11);
// bar(150,200,300,240);
// setfillstyle(1,15);
// bar(150,240,300,250);
// setcolor(0);
// pisz(155,200,'ZADZIALlANIE SAMOCZYNNEGO');
// pisz(155,211,'POWTOqRNEGO ZALlAaCZENIA.');
// pisz(155,222,'NIEUDANY CYKL SPZ.');
// pisz(155,240,'NACISqNIJ DOWOLNY KLAWISZ');
// delay(1000);
// setcolor(15);
// A:=READKEY;
// end;

// procedure pokaz5;
// var a:char;
// begin
// clearviewport;
// trafoet1(0);
// trafoet2(1,10,false);delay(2000);
// trafoet2(0,10,true);delay(500);
// trafoet2(0,10,false);delay(2000);
// trafoet2(1,10,true);delay(500);
// trafoet2(1,10,false);delay(200);
// trafoet2(0,10,true);delay(500);
// trafoet2(0,9,false);trafoet1(1);
// setfillstyle(1,11);
// bar(50,40,272,100);
// setfillstyle(1,15);
// bar(50,100,272,110);
// setcolor(0);
// pisz(55,40,'ZWARCIE NA TRANSFORMATORZE');
// pisz(55,51,'TROqJUZWOJENIOWYM eT2 110kV/6kV/15kV');
// pisz(55,62,'NIEUDANY CYKL SPZ.');
// pisz(55,73,'ZALlAaCZENIE ZASILANIA LINII 15KV Z');
// PISZ(55,84,'TRANSFORMATORA eT1.');
// pisz(55,100,'NACISqNIJ DOWOLNY KLAWISZ');
// delay(1000);
// setcolor(15);
// A:=READKEY;
// end;

// procedure pokaz6;
// var a:char;
// begin
// clearviewport;
// pol_pom1(0,0,1,1,0,1,1,1,0,1,true);pol_pom6(320,0,0,1,1,1,false);
// setfillstyle(1,11);
// bar(150,200,300,240);
// setfillstyle(1,15);
// bar(150,240,300,250);
// setcolor(0);
// pisz(155,200,'ZADZIALlANIE ZABEZPIECZENq');
// pisz(155,211,'ODLEGLlOSqCIOWYCH DRUGIEGO');
// pisz(155,222,'STOPNIA.');
// pisz(155,240,'NACISqNIJ DOWOLNY KLAWISZ');
// delay(1000);
// setcolor(15);
// A:=READKEY;
// end;

// procedure pokaz7;
// var a:char;
// begin
// clearviewport;
// pol_pom1(0,0,1,1,0,1,1,1,0,2,true);pol_pom6(320,0,0,1,1,1,false);
// setfillstyle(1,11);
// bar(150,200,310,240);
// setfillstyle(1,15);
// bar(150,240,310,250);
// setcolor(0);
// pisz(155,200,'ZADZIALlANIE ZABEZPIECZENq');
// pisz(155,211,'ODLEGLlOSqCIOWYCH TRZECIEGO');
// pisz(155,222,'STOPNIA.');
// pisz(155,240,'NACISqNIJ DOWOLNY KLAWISZ');
// delay(1000);
// setcolor(15);
// A:=READKEY;
// end;

// procedure informacja;
// var a:char;
// begin
// clearviewport;
// line(0,60,getmaxx,60);
// line(8,68,getmaxx-8,68);
// line(8,getmaxy-68,getmaxx-8,getmaxy-68);
// line(0,getmaxy-60,getmaxx,getmaxy-60);
// line(60,0,60,getmaxy);
// line(68,8,68,getmaxy-8);
// line(getmaxx-68,8,getmaxx-68,getmaxy-8);
// line(getmaxx-60,0,getmaxx-60,getmaxy);
// pisz(120,71,'KROqTKA INFORMACJA NA TEMAT OBSLlUGI PROGRAMU');
// pisz(72,83,' W PROGRAMIE WYKORZYSTANO UKLlAD NASTAWNI 110 kV PODOBNY DO NASTAWNI ZNAJDUJAaCEJ SIEa');
// pisz(72,95,'W ELEKTROCIEPLlOWNI POMORZANY. WSZELKIE ZMIANY ZOSTALlY WPROWADZONE JEDYNIE W CELU');
// pisz(72,107,'UZYSKANIA WIEaKSZEJ PRZEJRZYSTOSqCI RYSOWANYCH SCHEMATOqW.');
// pisz(72,119,'W CZEaSqCI OPISOWEJ PORUSZANIE SIEa ZOSTALlO ROZWIAaZANE W TEN SPOSOqB:');
// pisz(72,131,'KLAWISZE KURSORA (GOqRA I DOqLl) POWODUJAa PRZEMIESZCZANIE SIEa POMIEaDZY POSZCZEGOqLNYMI');
// pisz(72,143,'ELEMENTAMI NASTAWNI, NATOMIAST KLAWISZ ENTER POWODUJE PRZEJSqCIE DO KOLEJNEGO ');
// pisz(72,155,'EKRANU Z OPISEM NASTAWNI. W MENU PRZYJEaTO IDENTYCZNY SPOSOqB.KLAWISZ Esc NACISqNIETY');
// pisz(72,167,'W GLlOqWNYM MENU POWODUJE WYJSqIE Z PROGRAMU.');
// pisz(240,265,'NACISqNIJ DOWOLNY KLAWISZ');
// a:=readkey;
// end;

// procedure ry;
// begin
// setfillstyle(1,11);
 // bar(130,100,400,170);
 // setcolor(0);
 // pisz(140,110,'PROGRAM SYMULUJAaCY PRACEa NASTAWNI EL. 110kV');
 // PISZ(140,130,'DEMONSTRACJA ELEMENTOqW POqL POMIAROWYCH');
 // PISZ(140,141,'SYMULACJA  STANOqW  AWARYJNYCH');
 // PISZ(140,152,'KROqTKA INFORMACJA O PROGRAMIE');
// end;

 // procedure losowanie_awarii;
// var nrawarii:byte;
// begin
// repeat
// nrawarii:=random(6);
// until nrawarii<>starynr;
// starynr:=nrawarii;
// case nrawarii of
// 0:pokaz2;
// 1:pokaz3;
// 2:pokaz4;
// 3:pokaz5;
// 4:pokaz6;
// 5:POKAZ7;
// end;
// end;

// procedure odleglosc;
// var nr2:byte;
// begin
 // nr2:=random(2);
 // case nr2 of
 // 0:pokaz6;
 // 1:pokaz7;
 // end;
// end;
// procedure np;
// begin
 // setfillstyle(1,11);
 // bar(130,100,400,170);
 // bar(130,170,400,180);
 // setcolor(0);
 // pisz(140,110,'LOSOWY WYBOqR AWARII');
 // pisz(140,122,'UDANY SPZ');
 // pisz(140,134,'NIEUDANY SPZ');
 // pisz(140,146,'ZABEZPIECZENIA ODLEGLlOSqIOWE');
 // pisz(140,158,'ZWARCIE NA TRANSFORMATORZE');
 // pisz(140,170,'SYNCHRONIZACJA GENERATORA');
// end;

// procedure wybor_awarii;
// var q:char;
// begin
// repeat
 // clearviewport;
 // settextstyle(2,0,4);
 // setfillstyle(1,11);
 // bar(130,100,400,185);
 // SETFILLSTYLE(1,15);
 // bar(130,185,400,196);
 // setcolor(0);
 // PISZ(140,185,'WYBIERZ ODPOWIEDNIE POLE I NACISqNIJ ENTER');
 // if n1=1 then obwodka1(130,109,400,121,3);
 // if n1=2 then obwodka1(130,121,400,133,3);
 // if n1=3 then obwodka1(130,133,400,145,3);
 // if n1=4 then obwodka1(130,145,400,157,3);
 // if n1=5 then obwodka1(130,157,400,169,3);
 // if n1=6 then obwodka1(130,169,400,180,3);
 // repeat
 // setcolor(0);
 // pisz(140,110,'LOSOWY WYBOqR AWARII');
 // pisz(140,122,'UDANY SPZ');
 // pisz(140,134,'NIEUDANY SPZ');
 // pisz(140,146,'ZABEZPIECZENIA ODLEGLlOSqIOWE');
 // pisz(140,158,'ZWARCIE NA TRANSFORMATORZE');
 // pisz(140,170,'SYNCHRONIZACJA GENERATORA');
 // q:=readkey;
 // setfillstyle(1,7);
 // if ord(q)<>0 then begin
 // if q=#80 then n1:=n1+1 else if q=#72 then n1:=n1-1 else if (q<>#13) and (q<>#27) then beep;
 // if n1=7 then n1:=1;
 // if n1=0 then n1:=6;
 // if n1=1 then begin np;obwodka1(130,109,400,121,3);end;
 // if n1=2 then begin np;obwodka1(130,121,400,133,3);end;
 // if n1=3 then begin np;obwodka1(130,133,400,145,3);end;
 // if n1=4 then begin np;obwodka1(130,145,400,157,3);end;
 // if n1=5 then begin np;obwodka1(130,157,400,169,3);end;
 // if n1=6 then begin np;obwodka1(130,169,400,180,3);end;
 // end;
  // setfillstyle(1,11);
  // until (q=#13) or (q=#27);
   // if q=#27 then n1:=8;
 // case n1 of
// 1:losowanie_awarii;
// 2:pokaz3;
// 3:pokaz4;
// 4:odleglosc;
// 5:pokaz5;
// 6:pokaz2;
// else begin end;
// end;
// until n1=8
// end;

// procedure pytanie;
// var klawis:char;
// begin
  // setcolor(15);
  // pisz(30,300,'JESTESq PEWNY ZzE CHCESZ WYJSqCq Z PROGRAMU? TAK(ENTER/Esc/T)  NIE(INNE KLAWISZE)');
  // klawis:=readkey;
// if (klawis=#27) or (klawis=#13) or (klawis='T') or (klawis='t') then begin
   // clearviewport;
   // closegraph;
   // halt(1);
   // end else begin setfillstyle(0,0);bar(20,300,532,320);end;
// end;

// procedure napis;
// var q:char;n,m:integer;
// begin
 // clearviewport;
 // settextstyle(2,0,4);
 // n:=1;
 // setfillstyle(1,11);
 // bar(130,100,400,170);
 // SETFILLSTYLE(1,15);
 // bar(130,170,400,180);
 // setcolor(0);
 // PISZ(140,170,'WYBIERZ ODPOWIEDNIE POLE I NACISqNIJ ENTER');
 // obwodka1(130,130,400,141,3);
 // repeat
 // setcolor(0);
 // pisz(140,110,'PROGRAM SYMULUJAaCY PRACEa NASTAWNI EL. 110kV');
 // PISZ(140,130,'DEMONSTRACJA ELEMENTOqW POqL POMIAROWYCH');
 // PISZ(140,141,'SYMULACJA  STANOqW  AWARYJNYCH');
 // PISZ(140,152,'KROqTKA INFORMACJA O PROGRAMIE');
 // q:=readkey;
 // if q=#27 then pytanie;
 // setfillstyle(1,7);
 // if ord(q)<>0 then begin
 // if q=#80 then n:=N+1 else if q=#72 then n:=n-1 else if (q<>#13)and(q<>#27) then beep;
 // if n=4 then n:=1;
 // if n=0 then n:=3;
 // if n=1 then begin ry;obwodka1(130,130,400,141,3);end;
 // if n=2 then begin ry;obwodka1(130,142,400,152,3);end;
 // if n=3 then begin ry;obwodka1(130,151,400,163,3);end;
 // end; setfillstyle(1,11);
  // until q=#13;
  // case n of
// 1:pokaz;
// 2:begin n1:=1;wybor_awarii;end;
// 3:informacja;
// end
// end;


// begin
   // n:=vgamed;m:=vga;initgraph(m,n,'c:\turbo\');
// starynr:=0;cr1:=14;
// clearviewport;
// repeat NAPIS until false;
// closegraph;
// end.