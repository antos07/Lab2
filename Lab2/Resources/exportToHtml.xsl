<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/Table">
		<html>
			<body>
				<table>
					<tr>
						<th>ПІБ</th>
						<th>Структурний підрозділ</th>
						<th>Спеціальність</th>
						<th>Група</th>
						<th>Дата вступу</th>
					</tr>
					<xsl:for-each select="Row">
						<tr>
							<td><xsl:value-of select="StudentName"/></td>
							<td><xsl:value-of select="Faculty"/></td>
							<td><xsl:value-of select="FieldOfStudy"/></td>
							<td><xsl:value-of select="Group"/></td>
							<td><xsl:value-of select="EnteranceDate"/></td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
