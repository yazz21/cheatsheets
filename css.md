```css
# font
    font: FONT-WEIGHT FONT-STYLE FONT-VARIANT FONT-SIZE/LINE-HEIGHT FONT-FAMILY;
    font: bold italic small-caps 1em/1.5em verdana,sans-serif;

# select html element
    HTML
        <p class="text side">...</p>
    CSS
        .text.side{
        }   

#  Media Query for print,
    <link type="text/css" rel="stylesheet" href="printstyle.css" media="print" />

# capital letter first letter
    p:first-letter{ text-transform:uppercase; }

# style selection 
    ::selection{background-color:red; color:white;font-weight:bold;}

# setting the font size to 62.5% in the <body> tag makes 1em equal to 10px.
    body{ font-size:62.5%; }

# reset all default browser settings
    html, body, div, span, applet, object, iframe,
    h1, h2, h3, h4, h5, h6, p, blockquote, pre,
    a, abbr, acronym, address, big, cite, code,
    del, dfn, em, font, img, ins, kbd, q, s, samp,
    small, strike, strong, sub, sup, tt, var,
    b, u, i, center,
    dl, dt, dd, ol, ul, li,
    fieldset, form, label, legend,
    table, caption, tbody, tfoot, thead, tr, th, td {
     margin: 0;
     padding: 0;
     border: 0;
     outline: 0;
     font-size: 100%;
     vertical-align: baseline;
     background: transparent;
    }
    body {
     line-height: 1;
    }
    ol, ul {
     list-style: none;
    }
    blockquote, q {
     quotes: none;
    }
    blockquote:before, blockquote:after,
    q:before, q:after {
     content: ‘’;
     content: none;
    }
    /**
     * remember to define focus styles!
     */
    :focus {
     outline: 0;
    }
    /**
     * remember to highlight inserts somehow!
     */
    ins {
     text-decoration: none;
    }
    del {
     text-decoration: line-through;
    }
    /**
     * tables still need ‘cellspacing=”0"’ in the markup
     */
    table {
     border-collapse: collapse;
     border-spacing: 0;
    }