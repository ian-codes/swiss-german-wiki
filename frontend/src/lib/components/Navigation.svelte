<script lang="ts">
    export let isMenuOpen: boolean = false;

    let menuItems = [
        "Account",
        "About this site",
        "Disclaimer"
    ];
    
    function handleMenuOpen() {
        isMenuOpen = !isMenuOpen;
    }
</script>

{#if isMenuOpen}
    <div class="backdrop"></div>
{/if}
<nav>
    <button on:click={handleMenuOpen}>menu</button>
    {#if isMenuOpen}
        <ol>
            {#each menuItems as menuItem}
                <li>
                    <a href="{menuItem.toLowerCase()}">
                        {menuItem}
                    </a>
                </li>
            {/each}
        </ol>
    {/if}
</nav>


<style>
    .backdrop {
        z-index: 4;
        pointer-events: none;
        position: fixed;
        inset: 0;
        background: black;
        opacity: 0;
    }

    nav {
        z-index: 6;
        position: relative;
    }

    button {
        z-index: 5;
        cursor: pointer;
        font-size: 1em;
        font-weight: bold;
        padding: 1em;
        box-shadow: 0 2px 3px black;
    }

    ol {
        z-index: 3;
        position: absolute;
        right: 0;
        top: 4em;
        list-style: none;
        display: flex;
        flex-direction: column;
        justify-content: space-evenly;
        gap: 1em;
        width: max-content;
    }

    ol a {
        display: block;
        color: white;
        padding: 1em;
        background: gray;
        box-shadow: 0 2px 5px black;
        text-decoration: none;
    }

    ol a:hover {
        background: var(--gradient);
        color: white;
    }
</style>