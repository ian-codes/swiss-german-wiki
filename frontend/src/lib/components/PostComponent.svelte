<script lang="ts">
    import { Post } from "../models/Post";

    const newPost: Post = new Post("hellothere"
    , "es bedeutet so viel wie x"
    , "it means the following z"
    , "Don't do it, you won't be able to say hello ok?"
    , "max123"
    , "01.01.2024")

    let isCollapsed: boolean = true;

    function handleCollapse() {
        isCollapsed = !isCollapsed;
    }
</script>


<div id="{newPost.word}" class="container" class:open={!isCollapsed}>
    <div class="row">
        <span class="title">Word or saying</span>
        <span class="word">
            {newPost.word}
        </span>
    </div>

    <button on:click={handleCollapse}>
        {isCollapsed ? "show more" : "show less"}
        <span class="arrow" class:arrow-collapsed={isCollapsed}></span>
    </button>

    {#if !isCollapsed}
        <div class="row">
            <span class="title">German definition</span>
            <p class="definition">
                {newPost.definitionDE}
            </p>
        </div>

        <div class="row">
            <span class="title">English definition</span>
            <p class="definition">
                {newPost.definitionEN}
            </p>
        </div>

        <div class="row">
            <span class="title">Usage example</span>
            <p class="example">
                {newPost.example}
            </p>
        </div>

        <div class="last-row">
            <span class="author">
                by 
                <a href="user/{newPost.author}">
                    {newPost.author}
                </a>
            </span>
            <span class="timestamp">
                {newPost.timestamp}
            </span>
        </div>
    {/if}
</div>


<style>
    .container {
        z-index: 2;
        position: relative;
        width: 100%;
        display: flex;
        flex-direction: column;
        justify-content: space-between;
        gap: 1em;
        padding: 1em;
        background: rgba(211, 211, 211, 0.4);
        color: black;
        box-shadow: 2px 5px 10px rgba(0, 0, 0, 0.5);
        font-size: 1.2em;
        transition: all .2s;
    }
    .container.open {
        box-shadow: 0 0 0 3px var(--clr-2);
    }

    button {
        z-index: 3;
        position: relative;
        font-size: 1em;
        font-weight: lighter;
        letter-spacing: 3px;
        cursor: pointer;
        padding: .5em 1em;
        opacity: .5;
        display: flex;
        align-items: center;
        justify-content:  start;
        gap: .5em;
        transition: all .2s;
    }
    button .arrow {
        background: url("$lib/components/arrow.png");
        background-position: center;
        background-size: cover;
        display: block;
        width: 25px;
        aspect-ratio: 1;

        transform: rotate(180deg);
        transition: all .2s;
    }
    button .arrow-collapsed {
        transform: rotate(0);
    }
    button:hover {
        opacity: 1;
        color: white;
        background: gray;
    }
    button:hover .arrow {
        filter: invert(1);
    }

    .row {
        display: flex;
        flex-direction: column;
        gap: .5em;
        padding: 1em;
        background: rgba(255, 255, 255, 0.5);
        box-shadow: 2px 3px 2px rgba(0, 0, 0, 0.1);
    }

    .last-row {
        display: flex;
        flex-direction: row;
        justify-content: startn;
        gap: 1em;
        margin-top: 1em;
        padding: 0 1em;
    }

    .author, .timestamp {
        font-size: .8em;
        opacity: .8;
        font-weight: bold;
    }

    .title {
        font-weight: lighter;
        font-size: .7em;
        opacity: .5;
        text-transform: uppercase;
        letter-spacing: 2px;
    }

    .word {
        font-size: 1.5em;
        font-weight: bold;
    }

    .example {
        font-style: italic;
    }
</style>