# Tp 5
## ¿String es una tipo por valor o un tipo por referencia?
String es un tipo de referencia

## ¿Qué secuencias de escape tiene el tipo string?
Las secuencias de escape de string son: 
- \'	Single quote	
- \"	Double quote	
- \ \	Backslash	
- \0	Null	
- \a	Alert	
- \b	Backspace	
- \f	Form feed	
- \n	New line	
- \r	Carriage return	
- \t	Horizontal tab	
- \v	Vertical tab	
- \u	Unicode escape sequence (UTF-16)	
- \U	Unicode escape sequence (UTF-32)	
- \x	Unicode escape sequence similar to "\u" except with variable length	

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
El @ en un string se utiliza para indicar que una cadena debe interpretarse textualmente, es decir, si una cadena tiene una arroba(@) justo antes de las comillas de apertura, la cadena se interpretará literalmente sin prestar atención a códigos de escape, saltos de línea, o cualquier otro símbolo que está contenga y que pudiera hacer protestar al compilador o hacer que éste interpretara de forma especial dichos símbolos.

El $ en un string se utiliza para especificar cuantas llaves comienzan y terminan una interpolacion.