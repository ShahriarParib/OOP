#include<stdio.h>
#define pi 3.1416
int nr=0,nc=0,d1[100]= {},d2[100]= {},id=0,i;
float sum1=0,sum2=0;
void add_circle()
{
    float r;
    printf("value of radius:");
    scanf("%f",&r);
    d1[id]=r;
    d2[id]=-1;
    id++;
    sum1=sum1+pi*r*r;
    nc++;
}
void add_rectangle()
{
    float h,w;
    printf("value of height and width:");
    scanf("%f%f",&h,&w);
    d1[id]=h;
    d2[id]=w;
    sum2=sum2+h*w;
    id++;
    nr++;
}
void item_list()
{
    for(int i=0; d1[i]!=0; i++)
    {
        if(d2[i]==-1)
        {
            printf("%d.circle radius: %d\n",i+1,d1[i]);
        }
        else
        {
            printf("%d.rectangle Height and width: %d %d\n",i+1,d1[i],d2[i]);
        }
    }
}
void get_statistics()
{
    printf("Total shapes:%d\n",nc+nr);
    printf("Total number of rectangle:%d\n",nr);
    printf("Total number of circles:%d\n",nc);
    printf("Total area:%f\n",sum1+sum2);
    printf("Total area of circles:%f\n",sum1);
    printf("Total area of rectangles:%f\n",sum2);

}
int main()
{
    printf("1.Add a circle\n");
    printf("2.Add a rectangle\n");
    printf("3.List items\n");
    printf("4.Get statistics\n");
    printf("5.Exit");

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
            add_rectangle();
            break;
        case 3:
            item_list();
            break;
        case 4:
            get_statistics();
            break;
        case 5:
            return 0;
        default:
            printf("invalid input");
            break;

        }
    }
}
