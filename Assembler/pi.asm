; Imię i Nazwisko: Dawid Kowalski
; Numer albumu: s227811
; Aktualny rok akademicki: 2
; Numer grupy: 1
; Treść projektu: Program oblicza przybliżenie liczby pi metodą szeregu Leibniza przy użyciu jednostki FPU.

section .data
    cztery      dd 4.0
    dwa         dd 2.0
    minus_jeden dd -1.0

section .text
    global oblicz_pi

oblicz_pi:
    push rbp
    mov rbp, rsp
    sub rsp, 16

    finit
    fldz
    fld1
    fld1

    test rcx, rcx
    jz .koniec

.petla:
    fld1
    fdiv st0, st1
    fmul st0, st2
    faddp st3, st0
    
    fld dword [rel dwa]
    faddp st1, st0
    
    fld dword [rel minus_jeden]
    fmulp st2, st0
    
    dec rcx
    jnz .petla

.koniec:
    fstp st0
    fstp st0
    
    fld dword [rel cztery]
    fmulp st1, st0
    
    fstp dword [rbp-4]
    movss xmm0, [rbp-4]
    
    add rsp, 16
    pop rbp
    ret