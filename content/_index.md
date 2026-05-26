
+++

title = "Codifica di Huffman"
description = "Dettagli sull'algoritmo e sulla logica"
outputs = ["Reveal"]
aliases = [
    "/guide/"
]

+++

{{% multicol %}}
{{% col %}}

![](imgs/huffman-tree.svg)

<small>
<a href="https://commons.wikimedia.org/wiki/File:Huffman_tree.svg">Dcoetzee</a>, Public domain, da Wikimedia Commons
</small>

{{% /col %}}

{{% col class="d-flex flex-column justify-content-center" %}}

# La codifica di **Huffman**

<br>

<small>

A cura di Nicholas Magi — `nicholas.magi[at]ispascalcomandini.it`

</small>

<br>

{{% pdf %}}

{{% /col %}}
{{% /multicol %}}

---

<img class="w-100" src="imgs/info-mindmap.png"/>

---

## Algoritmi di **Compressione**

In quale ambito ricadono tra *elaborazione*, *trasporto* e *memorizzazione*?

---

## Compressione dei dati

{{% callout type="cite" src="Wikipedia — Compressione dei dati" srcLink="https://it.wikipedia.org/wiki/Compressione_dei_dati" %}}

La **compressione dei dati**, in informatica e nelle telecomunicazioni, è la tecnica di **elaborazione dati** che, attuata a mezzo di opportuni **algoritmi**, permette la **riduzione** della quantità di bit necessari alla **rappresentazione** in **forma digitale** di un'**informazione**.

{{% /callout %}}

---

Due grandi categorie

{{% multicol %}}
{{% col %}}

## Compressione **lossy**
* Comporta una perdita **irreversibile** di parte dell'informazione (*spesso inosservabile all'occhio umano*).
* Algoritmi più efficienti in termini di **spazio risparmiato**. 

<br/>
<br/>

{{% callout type="warning" %}}
Ci deve essere un buon *trade-off* tra la **quantità di informazione persa** e l'**integrità del contenuto**.
{{% /callout%}}

{{% /col %}}
{{% col %}}
## Compressione **lossless**
* Mantiene **intatta** l'informazione associata ai dati.
  * Algoritmi che "**riorganizzano**" i dati per occupare meno spazio — garantendo la ricostruzione del contenuto originale al 100%. 

{{% /col %}}
{{% /multicol %}}

---

{{% section %}}
### Compressione **lossy**

{{% callout type="warning" %}}

Ci deve essere un buon *trade-off* tra la **quantità di informazione persa** e l'**integrità del contenuto**.

{{% /callout%}}

<br/>

Un esempio
$\downarrow$

---

![](imgs/kira-compressed.png)

---

![](imgs/kira.jpeg)

---

Tanto spazio risparmiato, ma il soggetto era **irriconoscibile**.

---

#### Standard che usano compressione **lossy**

- MP3 (Audio)
- ...
- MPEG-4 (Video)
- ...
- JPEG (Immagini)
- ...

{{% /section %}}

---

{{% section %}}
### Compressione **lossless**

Utilizzata per contenuti in cui **non è accettabile** una **perdita di informazione** (file di testo o un programma, per esempio).

---

## Problema
Gli algoritmi di compressione lossless **non possono sempre garantire** che ogni insieme di dati in input **diminuisca di dimensione**.

<br/>

{{% callout title="Per i più curiosi" %}}
Buona e semplice dimostrazione matematica su [Wikipedia](https://it.wikipedia.org/wiki/Compressione_dati_senza_perdita).
{{% /callout %}}

---

Alcuni esempi di algoritmi di compressione **lossless**:
- **Codifica di Huffman** $\quad (\leftarrow$ noi approfondiamo questa!$)$ 
- Codifica (o *compressione*) aritmetica
- Lempel-Ziv-Welch (LZW)
- Deflate (combinazione di **LZW** e **Huffman**)
- ... 

---

| **FORMATO/PROGRAMMA** | **AMBITO**   | **ALGORITMO**     |
|-----------------------|--------------|-------------------|
| GIF                   | Immagini     | LZW               |
| PNG                   | Immagini     | Deflate           |
| GZip                  | Archivio ZIP | Deflate           |
| WinRar                | Archivio ZIP | Algoritmo proprio |
| ...                | ... | ... |

{{% /section %}}

---

{{% multicol %}}

{{% col %}}

![](imgs/david-huffman.jpg)

David Huffman, 1925 - 1999

{{% /col %}}
{{% col class="d-flex flex-column justify-content-center" %}}
## Codifica di Huffman 
{{% /col %}}

{{% /multicol %}}

---

### Varie codifiche lossless

{{% multicol %}}
{{% col %}}
#### **Fixed**-length coding 

Codifica che mappa ciascun carattere ad un codice corrispondente di lunghezza prefissata (ex. ASCII).

{{% /col %}}
{{% col %}}
#### **Variable**-length coding 

I caratteri codificati possono avere lunghezze diverse.

{{% /col %}}
{{% /multicol %}}

--- 

{{% callout type="danger" title="Problema" %}}
risparmiare spazio quando memorizzo un'informazione.
{{% /callout %}}

<br/>

{{% fragment %}}

{{% callout type="success" title="Soluzione" %}}
associare un codice **più corto** ai caratteri **più frequenti**, e **più lungo** a quelli **meno**.
{{% /callout %}}

{{% /fragment %}}

---

## L'algoritmo

{{% code path="static/files/Huffman.cs" %}}

---

## Gli step

| **STEP**                                                                                            | **CONSEGNA**                                                                                                           |
|-----------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------|
| (1) Costruzione tabella delle frequenze dei caratteri                                               | [`char-frequency.md`](https://nickolausenteaching.github.io/#!./as2526/3M-Pascal/UD/huffman/char-frequency.md)         |
| (2) Costruzione dell'albero di Huffman (richiede di avere una PQ — possibilmente basata su MinHeap) | [`build-huffman-tree.md`](https://nickolausenteaching.github.io/#!./as2526/3M-Pascal/UD/huffman/build-huffman-tree.md) |
| (3) Calcolo dei codici per ciascun carattere                                                        | [`TODO`](#)                                                                                                            |
| (4) Codifica del testo in input                                                                     | [`TODO`](#)                                                                                                            |