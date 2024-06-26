#include<stdio.h>
#define pi 3.1416
int d1[100]= {},d2[100]= {};
int id=0;
int sum1=0;
sum2=0,ti1=0,ti2=0;
void add_circle()
{
    int r;
    scanf("%d",&r);
    d1[id]=r;
    d2[id]=-1;
    id++;
    sum1+=pi*r*r;
    ti1++;
}
void add_triangle()
{
    int h,w;
    scanf("%d %d",&h,&w);
    d1[id]=h;
    d2[id]=w;
    id++;
    sum2+=h*w;
    ti2++;
}
void item_list()
{
    printf("id  shape  paramemter\n");
    for(int i=0; d1[i]!=0; i++)
    {
        if(d2[i]==-1)
        {
            printf("%d  circle    %d\n",i+1,d1[i]);
        }
        else
        {
            printf("%d  rectangle %d %d\n",i+1,d1[i],d2[i]);
        }
    }
}
void statistics()
{
    printf("Total number of items: %d\n",ti1+ti2);
    printf("Total number of circle: %d\n",ti1);
    printf("Total number of rectangle: %d\n",ti2);
    printf("Total area of items: %d\n",sum1+sum2);
    printf("Total area of circle: %d\n",sum1);
    printf("Total area of rectangle: %d\n",sum2);
}
int main()
{
    printf("1.add_circle\n");
    printf("2.add_triangle\n");
    printf("3.item_list\n");
    printf("4.statistics\n");
    printf("5.exit");
    while(1)
    {

        int n;
        scanf("%d",&n);

        switch(n)
        {
        case 1:
            add_circle();
            break;
        case 2:
            add_triangle();
            break;
        case 3:
            item_list();
            break;
        case 4:
            statistics();
            break;
        case 5:
            return 0;
        default:
            printf("wrong number");
            break;
        }
    }
}
