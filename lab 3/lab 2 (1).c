#include<stdio.h>
#define pi 3.1416
int nr=0,nc=0,ncube=0;
int id=0,i;
float sum1=0,sum2=0,sum3=0;
struct circle
{
    float r;
};
struct rectangle
{
    float h;
    float w;
};
struct cube
{
    float h;
    float w;
    float t;
};
struct crcube
{
    struct circle r[100];
    struct rectangle hw[100];
    struct cube hwt[100];
};
int main()
{
    float r,h,w,t;
    printf("1.Add a circle\n");
    printf("2.Add a rectangle\n");
    printf("3.Add a cube\n");
    printf("4.List items\n");
    printf("5.Get statistics\n");
    printf("6.Exit");
    struct crcube parameters[100];
    while(1)
    {
        int n;
        scanf("%d",&n);
        switch(n)
        {
        case 1:
            printf("value of radius:");
            scanf("%f",&r);
            parameters[id].r[id].r=r;
            parameters[id].hw[id].h=-1;
            id++;
            sum1=sum1+pi*r*r;
            nc++;
            break;
        case 2:
            printf("value of height and width:");
            scanf("%f%f",&h,&w);
            parameters[id].hw[id].h=h;
            parameters[id].hw[id].w=w;
            parameters[id].hwt[id].t=-1;
            parameters[id].r[id].r=-1;
            sum2=sum2+h*w;
            id++;
            nr++;
            break;
        case 3:
            printf("value of height,width and thickness:");
            scanf("%f%f%f",&h,&w,&t);
            parameters[id].hwt[id].h=h;
            parameters[id].hwt[id].w=w;
            parameters[id].hwt[id].t=t;
            id++;
            sum3=sum3+h*w;
            ncube++;
            break;
        case 4:
            printf("The list of items:\n");
            printf("Id  type        Dimension\n");
            for(int i=0; i<id; i++)
            {
                if( parameters[i].hw[i].h==-1)
                {
                    printf("%d.  circle     [%f]\n",i+1, parameters[i].r[i].r);
                }
                else if( parameters[i].hwt[i].t==-1&&  parameters[i].r[i].r==-1)
                {
                    printf("%d.  rectangle  [%f]*[%f]\n",i+1,  parameters[i].hw[i].h, parameters[i].hw[i].w);
                }
                else
                {
                    printf("%d.  cube       [%f]*[%f]*[%f]\n",i+1,parameters[i].hwt[i].h,parameters[i].hwt[i].w,parameters[i].hwt[i].t);
                }
            }
            break;
        case 5:
            printf("STATISTICS:\n");
            printf("Total shapes:%d\n",nc+nr+ncube);
            printf("Total number of rectangles:%d\n",nr);
            printf("Total number of circles:%d\n",nc);
            printf("Total number of cubes:%d\n",ncube);
            printf("Total area:%f\n",sum1+sum2+sum3);
            printf("Total area occupied by circles:%f\n",sum1);
            printf("Total area occupied by rectangles:%f\n",sum2);
            printf("Total area occupied by cubes:%f\n",sum3);
            break;
        case 6:
            return 0;
            break;
        case 7:
            printf("INVALID INPUT");
        }
    }
}

