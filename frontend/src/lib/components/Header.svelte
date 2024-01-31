<script lang="ts">
    import Navigation from "./Navigation.svelte";

    let isMenuOpen: boolean = false;
</script>

<div class="backdrop" class:active={isMenuOpen}></div>
<header>
    <div class="top">
        <h1>
            <span class="logo"></span>
            Swiss German <span>Wiki</span>
        </h1>

        <Navigation isMenuOpen={isMenuOpen} />
    </div>
    <input placeholder="search for word/saying" />
</header>


<style>
    header {
        padding: 1em;
        display: flex;
        flex-direction: column;
        gap: 1em;
        margin-bottom: 2em;
    }
    h1 {
        display: flex;
        align-items: center;
        gap: .5em;
        font-size: 1.5em;
        font-weight: lighter;
    }
    h1 span {
        color: var(--clr-2);
    }
    h1 .logo {
        background-image: url("$lib/components/logo.png");
        background-size: contain;
        background-position: center;
        background-repeat: no-repeat;
        width: 30px;
        height: 30px;
        display: inline-block;
    }
    .top {
        display: flex;
        flex-direction: row;
        align-items: center;
        justify-content: space-between;
    }


    .backdrop {
        position: fixed;
        inset: 0;
        pointer-events: none;
        background: black;
        opacity: 0;
        z-index: 1;
    }
    .backdrop.active {
        opacity: .4;
        pointer-events: all;
    }

    input {
        padding: .5em 1em;
        font-size: 1em;
        font-weight: bold;
        transition: all .2s;
        border: none;
        box-shadow: 0 2px 2px 0px rgba(0, 0, 0, 0.404)
        , 0 0 20px rgba(0, 0, 0, 0.1);
        transition: all .2s;
    }
    input::placeholder {
        font-weight: lighter;
        letter-spacing: 1px;
        opacity: .8;
    }
    input:focus {
        background: var(--clr-2);
        color: white;
    }
    input:focus::placeholder {
        color: white;
    }
</style>