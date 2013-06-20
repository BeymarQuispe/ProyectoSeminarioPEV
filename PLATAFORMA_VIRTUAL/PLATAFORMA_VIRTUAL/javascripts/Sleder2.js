$slideshow = {
    context: false,
    tabs: false,
    timeout: 5000,
    slideSpeed: 600,
    tabSpeed: 500,
    fx: 'scrollRight',

    init: function () {
        this.context = $('#slideshow1');
        this.tabs = $('ul.slides1-nav li', this.context);
        this.tabs.remove();
        this.prepareSlideshow();
    },

    prepareSlideshow: function () {
        $('div.slides1 > ul', $slideshow.context).cycle({
            fx: $slideshow.fx,
            timeout: $slideshow.timeout,
            speed: $slideshow.slideSpeed,
            fastOnEvent: $slideshow.tabSpeed,
            pager: $('ul.slides-nav', $slideshow.context),
            pagerAnchorBuilder: $slideshow.prepareTabs,
            before: $slideshow.activateTab,
            pauseOnPagerHover: true,
            pause: true,
            pagerEvent: 'mouseover'
        });

    },

    prepareTabs: function (i, slide) {
        return $slideshow.tabs.eq(i);
    },

    activateTab: function (currentSlide, nextSlide) {
        var activeTab = $('#' + nextSlide.id + '-link', $slideshow.context);
        if (activeTab.length) {
            $slideshow.tabs.removeClass('on');
            activeTab.parent().addClass('on');
        }
    }
};


$(function () {
    $('body').addClass('js');
    $slideshow.init();
});