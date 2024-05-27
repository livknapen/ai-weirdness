<template>
    <img class="stars-bg" src="/img/stars.svg" alt="Stars" />
    <div class="header-text">
        <h3>Choose a quest!</h3>
        <p>You can select different tasks with the arrows.</p>
    </div>
    <div id="slideshow-wrap">
        <input type="radio" id="button-1" name="controls" defaultChecked />
        <label for="button-1"></label>
        <input type="radio" id="button-2" name="controls" />
        <label for="button-2"></label>
        <input type="radio" id="button-3" name="controls" />
        <label for="button-3"></label>
        <label for="button-1" class="arrows" id="arrow-1">></label>
        <label for="button-2" class="arrows" id="arrow-2">></label>
        <label for="button-3" class="arrows" id="arrow-3">></label>
        <div id="slideshow-inner">
            <ul>
                <li id="slide1">
                    <img class="quest1" src="/img/quest1.svg" alt="Quests" />
                </li>
                <li id="slide2">
                    <img src="/img/quest2.svg" alt="Quests"/>
                </li>
                <li id="slide3">
                    <img src="/img/quest3.svg" alt="Quests"/>
                </li>
            </ul>
        </div>
    </div>
</template>

<style>
    @import url("https://fonts.cdnfonts.com/css/ethnocentric");
    body {
        background-color: #061929;
        margin: 0;
        padding: 0;
        font-family: video, serif;
        font-style: normal;
        font-weight: 350;
        background-repeat: repeat;
        height: 500px;
    }
  
    .stars-bg {
        margin-top: -50px;
    }
  
    .header-text {
        margin: 0vw 10vw;
    }

    h3 {
        color: white;
        margin-bottom: 0;
    }

    p {
        color: white;
        margin-top: 5px;
    }

    @font-face {
        font-family: 'WebSymbolsRegular';
        src: url('http://html5css3demos.bplaced.net/css3-slider-v3/websymbols-regular-webfont.eot');
        src: url('http://html5css3demos.bplaced.net/css3-slider-v3/websymbols-regular-webfont.eot?#iefix') format('embedded-opentype'), url('http://html5css3demos.bplaced.net/css3-slider-v3/websymbols-regular-webfont.woff') format('woff'), url('http://html5css3demos.bplaced.net/css3-slider-v3/websymbols-regular-webfont.ttf') format('truetype'), url('http://html5css3demos.bplaced.net/css3-slider-v3/websymbols-regular-webfont#WebSymbolsRegular') format('svg');
    }

    #slideshow-wrap {
        display: block;
        height: 150px;
        max-width: 275px;
        margin: auto;
        margin-top: 100px;
        position: relative;
    }

    #slideshow-inner {
        width: 100%;
        height: 100%;
        overflow: hidden;
        position: relative;
    }

    #slideshow-inner>ul {
        list-style: none;
        height: 100%;
        width: 500%;
        overflow: hidden;
        position: relative;
        left: 0px;
        margin: 0;
        -webkit-transition: left .8s cubic-bezier(0.77, 0, 0.175, 1);
        -moz-transition: left .8s cubic-bezier(0.77, 0, 0.175, 1);
        -o-transition: left .8s cubic-bezier(0.77, 0, 0.175, 1);
        transition: left .8s cubic-bezier(0.77, 0, 0.175, 1);
    }

    #slideshow-inner>ul>li {
        width: 20%;
        height: 320px;
        float: left;
        position: relative;
    }

    #slideshow-inner>ul>li>img {
        margin: auto;
        height: 100%;
        margin-top: -90px;
        scale: 1.65;
        margin-left: -35px;
    }

    #slideshow-wrap input[type=radio] {
        position: absolute;
        left: 50%;
        bottom: 15px;
        z-index: 100;
        visibility: hidden;
    }

    #slideshow-wrap label:not(.arrows):active { bottom: -46px }

    #slideshow-wrap input[type=radio]#button-1:checked~label[for=button-1] { background-color: white }

    #slideshow-wrap input[type=radio]#button-2:checked~label[for=button-2] { background-color: white }

    #slideshow-wrap input[type=radio]#button-3:checked~label[for=button-3] { background-color: white }

    #slideshow-wrap label[for=button-1] { margin-left: -36px }

    #slideshow-wrap label[for=button-2] { margin-left: -18px }

    #slideshow-wrap input[type=radio]#button-1:checked~#slideshow-inner>ul { left: 0 }

    #slideshow-wrap input[type=radio]#button-2:checked~#slideshow-inner>ul { left: -100% }

    #slideshow-wrap input[type=radio]#button-3:checked~#slideshow-inner>ul { left: -200% }

    label.arrows {
        font-family: video, serif;
        font-size: 75pt;
        color: white;
        position: absolute;
        margin-top: -25px;
        top: 50%;
        display: none;
        cursor: pointer;
        z-index: 1;
        background-color: transparent;
        -webkit-transition: opacity .2s;
        -moz-transition: opacity .2s;
        -o-transition: opacity .2s;
        transition: opacity .2s;
    }

    label.arrows:hover { opacity: 1 }

    label.arrows:active { margin-top: -23px }

    input[type=radio]#button-1:checked~.arrows#arrow-2, input[type=radio]#button-2:checked~.arrows#arrow-3, input[type=radio]#button-3:checked~.arrows#arrow-4, input[type=radio]#button-4:checked~.arrows#arrow-5 {
        right: -55px;
        display: block;
    }

    input[type=radio]#button-2:checked~.arrows#arrow-1, input[type=radio]#button-3:checked~.arrows#arrow-2, input[type=radio]#button-4:checked~.arrows#arrow-3, input[type=radio]#button-5:checked~.arrows#arrow-4 {
        left: -55px;
        display: block;
        -webkit-transform: scaleX(-1);
        -moz-transform: scaleX(-1);
        -ms-transform: scaleX(-1);
        -o-transform: scaleX(-1);
        transform: scaleX(-1);
    }

    input[type=radio]#button-2:checked~.arrows#arrow-1 { left: -19px }

    input[type=radio]#button-3:checked~.arrows#arrow-2 { left: -37px }

    input[type=radio]#button-5:checked~.arrows#arrow-4 { left: -73px }
</style>
