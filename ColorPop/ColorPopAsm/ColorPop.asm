.data

    coeff_R real4  0.299
    coeff_G real4  0.587
    coeff_B real4  0.114


.code 

ProcessPixel proc

    
    ; Zachowaj oryginalne wartoœci RGB
    cvtsi2ss xmm0, rcx    ; Original R
    cvtsi2ss xmm1, rdx    ; Original G
    cvtsi2ss xmm2, r8     ; Original B
    
    ; Zachowaj kopie oryginalnych wartoœci
    movaps xmm6, xmm0
    movaps xmm7, xmm1
    movaps xmm8, xmm2
    
    ; Wczytaj target colors
    mov rax, [rsp+40]     ; Target R
    cvtsi2ss xmm3, eax
    mov rax, [rsp+48]     ; Target G
    cvtsi2ss xmm4, eax
    mov rax, [rsp+56]     ; Target B
    cvtsi2ss xmm5, eax
    
    ; Konwertuj tolerance na float
    cvtsi2ss xmm9, r9d
    
    ; SprawdŸ tolerancjê dla wszystkich sk³adowych
    subss xmm0, xmm3          ; originalR - targetR
    andps xmm0, [abs_mask]    ; Abs value
    comiss xmm0, xmm9         ; Compare with tolerance
    ja convert_to_brightness   ; If > tolerance, convert
    
    subss xmm1, xmm4          ; originalG - targetG
    andps xmm1, [abs_mask]    ; Abs value
    comiss xmm1, xmm9         ; Compare with tolerance
    ja convert_to_brightness   ; If > tolerance, convert
    
    subss xmm2, xmm5          ; originalB - targetB
    andps xmm2, [abs_mask]    ; Abs value
    comiss xmm2, xmm9         ; Compare with tolerance
    ja convert_to_brightness   ; If > tolerance, convert
    
    ; Jeœli wszystkie w tolerancji, zapisz oryginalne kolory
    mov rax, [rsp+64]         ; WskaŸnik do tablicy wyników
    movss dword ptr [rax], xmm6    ; original R
    movss dword ptr [rax+4], xmm7  ; original G
    movss dword ptr [rax+8], xmm8  ; original B
    jmp end_proc
    
convert_to_brightness:
    ; Obliczanie brightness dla ka¿dej sk³adowej 
    movaps xmm0, xmm6         ; R
    mulss xmm0, [coeff_R]     ; R * 0.299
    
    movaps xmm1, xmm7         ; G
    mulss xmm1, [coeff_G]     ; G * 0.587
    
    movaps xmm2, xmm8         ; B
    mulss xmm2, [coeff_B]     ; B * 0.114
    
    ; Sumowanie
    addss xmm0, xmm1
    addss xmm0, xmm2
    
    ; Zapisywanie wynikow
    mov rax, [rsp+64]         ; WskaŸnik do tablicy wyników
    movss dword ptr [rax], xmm0    ; brightness
    movss dword ptr [rax+4], xmm0  ; brightness
    movss dword ptr [rax+8], xmm0  ; brightness
    
end_proc:
    xor rax, rax              ; Zwróæ 0
    ret

; Dane
ALIGN 16
abs_mask dd 7fffffffh, 0, 0, 0


ProcessPixel endp 
END





