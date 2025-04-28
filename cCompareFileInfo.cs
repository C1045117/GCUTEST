using System;
using System.Collections;
using System.IO;

namespace GCUv2;

public class cCompareFileInfo : IComparer
{
	public int Compare(object x, object y)
	{
		FileInfo fileInfo = (FileInfo)x;
		FileInfo fileInfo2 = (FileInfo)y;
		return DateTime.Compare(fileInfo.LastWriteTime, fileInfo2.LastWriteTime);
	}

	int IComparer.Compare(object x, object y)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Compare
		return this.Compare(x, y);
	}
}
