using System;

namespace ce103_hw4_cs_dll
{
    public class Class1
    {
    }
}

# include<stdio.h>
# include<conio.h>
int fnCE103HW4Lib(unsigned char* fia, int fib, char* fic) =>
    //Empty Body...
    0;

/** \copydoc ce103_fibonacciNumber */
int ce103_fibonacciNumber(int fiIndex)
{
	int n = 0, first = 0, second = 1, result = 0, i;
	//INT, INTEGER, INT4		:	-2147483648, +2147483647
	for (i = 0; i < fiIndex; i++)
	{
		if (i <= 1)
			result = i;
		else
		{
			result = first + second;
			first = second;
			second = result;
		}
	}

	return result;
}
/** \copydoc ce103_strrev */
    char* ce103_strrev(char* fiStr)
//strrev — Reverses a string

{
	if (!fiStr || !*fiStr)
		return fiStr;

	int i = ce103_strlen(fiStr) - 1, j = 0;

	char ch;
	while (i > j)
	{
		ch = fiStr[i];
		fiStr[i] = fiStr[j];
		fiStr[j] = ch;
		i--;
		j++;
	}
	return fiStr;
}

/** \copydoc ce103_strlen */
     int ce103_strlen(const char* fiStr)
//strlen — Returns the length of the string

{
	int c = 0;

	while (*(fiStr + c) != '\0')
		c++;

	return c;
}

/** \copydoc ce103_strcat */
     char* ce103_strcat(char* fiDest, char* fiSrc)
{
	char* start = fiDest;
	//CHAR(N)			:	MySQL de max. 255
	while (*fiDest != '\0')
	{
		fiDest++;
	}

	while (*fiSrc != '\0')
	{
		*fiDest = *fiSrc;
		fiDest++;
		fiSrc++;
	}

	*fiDest = '\0';
	return start;
}

/** \copydoc ce103_strcmp */
     int ce103_strcmp(const char* fiLhs, const char* fiRhs)

//strcmp — Reliable binary string comparison


{
	while ((*fiLhs != '\0' && *fiRhs != '\0') && *fiLhs == *fiRhs)
	{
		fiLhs++;
		fiRhs++;
	}

	if (*fiLhs == *fiRhs)
	{
		return 0; // strings are identical 
	}
	else
	{
		return *fiLhs - *fiRhs;
	}
}

/** \copydoc ce103_strcpy */
    char* ce103_strcpy(char* foDestination, const char* fiSource)
{
	char* start = foDestination;

	while (*fiSource != '\0')
	{
		*foDestination = *fiSource;
		foDestination++;
		fiSource++;
	}

	*foDestination = '\0';
	return start;
}

/** \copydoc ce103_hex2bin */
   void ce103_hex2bin(char* fiHex, int fiHexLen, unsigned char* foBin)
// hex2bin — Decodes a hexadecimally encoded binary string

{
	int iCnt = 0;

	while (*fiHex != 0)
	{
		if (iCnt >= fiHexLen) break;

		if (*fiHex >= '0' && *fiHex <= '9')
			*foBin = (*fiHex - '0') << 4;
		else if (*fiHex >= 'A' && *fiHex <= 'F')
			*foBin = ((*fiHex - 'A') + 10) << 4;
		else if (*fiHex >= 'a' && *fiHex <= 'f')
			*foBin = ((*fiHex - 'a') + 10) << 4;

		fiHex++; iCnt++;
		if (*fiHex == 0) break;
		if (iCnt >= fiHexLen) break;

		if (*fiHex >= '0' && *fiHex <= '9')
			*foBin |= (*fiHex - '0');
		else if (*fiHex >= 'A' && *fiHex <= 'F')
			*foBin |= ((*fiHex - 'A') + 10);
		else if (*fiHex >= 'a' && *fiHex <= 'f')
			*foBin |= ((*fiHex - 'a') + 10);

		fiHex++; iCnt++; foBin++;
	}
}

/** \copydoc ce103_bin2hex */
    void ce103_bin2hex(unsigned char* fiBin, int fiBinLen, char* foHex)
// bin2hex — Gets a hexadecimal representation of a binary data

{
	char uChr = 0;

	for (int y = 0; y < fiBinLen; y++)
	{
		uChr = ((*fiBin) & 0xF0) >> 4;
		if (uChr > 9) *foHex++ = (char)(uChr + 0x37);
		else *foHex++ = (char)(uChr + 0x30);

		uChr = (*fiBin++) & 0x0F;
		if (uChr > 9) *foHex++ = (char)(uChr + 0x37);
		else *foHex++ = (char)(uChr + 0x30);

	}
}