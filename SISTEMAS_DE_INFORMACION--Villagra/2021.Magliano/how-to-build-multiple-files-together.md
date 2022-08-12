# [How to concatenate multiple markdown files in a specific order](https://stackoverflow.com/q/60771330/6253165)

pandoc -s $(cat includes.txt) -o index.html

# [Set margin size when converting from Markdown to PDF with pandoc](https://stackoverflow.com/a/13516042/6253165)

---
title: "Habits"
author: John Doe
date: March 22, 2005
geometry: "left=3cm,right=3cm,top=2cm,bottom=2cm"
output: pdf_document
---
