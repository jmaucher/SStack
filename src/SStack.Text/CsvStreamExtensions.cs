//
// https://github.com/SStack/SStack.Text
// SStack.Text: .NET C# POCO JSON, JSV and CSV Text Serializers.
//
// Authors:
//   Demis Bellot (demis.bellot@gmail.com)
//
// Copyright 2012 SStack Ltd.
//
// Licensed under the same terms of SStack: new BSD license.
//

using System.Collections.Generic;
using System.IO;

namespace SStack.Text
{
	public static class CsvStreamExtensions
	{
		public static void WriteCsv<T>(this Stream outputStream, IEnumerable<T> records)
		{
			using (var textWriter = new StreamWriter(outputStream))
			{
				textWriter.WriteCsv(records);
			}
		}

		public static void WriteCsv<T>(this TextWriter writer, IEnumerable<T> records)
		{
			CsvWriter<T>.Write(writer, records);
		}

	}
}
