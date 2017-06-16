#include <stdio.h>
#define MAX_LEN 256

void print_image(FILE *fptr);

int main(void)
{
    char *filename = "ascii.txt";
    FILE *fptr = NULL;

    if((fptr = fopen(filename,"r")) == NULL)
    {
        fprintf(stderr,"Error opening %s\nPlease try again.\n",filename);
        return 1;
    }

    print_image(fptr);
    //another printf can be inserted here...

    fclose(fptr);

    return 0;
}

void print_image(FILE *fptr)
{
    char read_string[MAX_LEN];

    while(fgets(read_string,sizeof(read_string),fptr) != NULL)
        printf("%s",read_string);
}

