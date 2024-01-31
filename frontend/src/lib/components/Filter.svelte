<script lang="ts">
    export let item: string;

    export let activeFilter: string = "";

    function setActiveFilter(filter: string) {
        activeFilter = filter;
    }

    $: isActive = activeFilter === item;
</script>


<button class:active={isActive} title="{item}" data-after-content="{item}" on:click={() => setActiveFilter(item)}>
    <span class="{item} img"></span>
    {item}
</button>


<style>
    button {
        position: relative;
        display: flex;
        align-items: center;
        justify-content: start;
        gap: 6px;
        font-size: .9em;
        padding: .5em 1em;
        cursor: pointer;

        transition: all .2s;
    }
    button.active {
        background: var(--gradient);
        color: white;
        box-shadow: 0 2px 3px rgba(0, 0, 0, 0.3);
    }
    button.active .img {
        filter: invert(1);
    }
    button:hover {
        scale: 1.05;
        box-shadow: 0 2px 3px rgba(0, 0, 0, 0.3);
    }


    .img {
        border-radius: 100%;
        width: 20px;
        height: 20px;
        background-position: center;
        background-size: contain;
        background-repeat: no-repeat;

        transition: all .2s;
    }

    .trending {
        background-image: url("$lib/components/trending.png");
    }

    .recent {
        background-image: url("$lib/components/recent.png");
    }

    .top {
        background-image: url("$lib/components/top.png");
    }
</style>