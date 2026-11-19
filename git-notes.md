# Git notes

## Task 15 — Basic git

### Commands

Репозиторий создан через Visual Studio (`git init` выполнен автоматически при публикации на GitHub).

```bash
git checkout -b feature/git-basics
# дописал строку в README.md
git add README.md
git commit -m "docs: task 15 - change in feature branch"
git checkout main
git merge --no-ff feature/git-basics -m "merge: feature/git-basics into main"

git checkout -b feature/conflict-a
# заменил первую строку README.md на "# Версия A"
git add README.md
git commit -m "docs: task 15 - readme version A"
git checkout main
# заменил ту же первую строку README.md на "# Версия B"
git add README.md
git commit -m "docs: task 15 - readme version B"
git merge feature/conflict-a
# CONFLICT in README.md: вручную убрал маркеры <<<<<<<, =======, >>>>>>>
git add README.md
git commit -m "fix: task 15 - resolve merge conflict"

git log --graph --oneline --all
git push
```

### Output (git log --graph --oneline --all)

```
*   dee3911 fix: task 15 - resolve merge conflict
|\  
| * 740d36f docs: task 15 - readme version A
* | 696db41 docs: task 15 - readme version B
|/  
*   eb21fa2 merge: feature/git-basics into main
|\  
| * 9336e5a docs: task 15 - change in feature branch
|/  
*   a20401b merge: level 3 into main
|\  
| * 30520bd feat: add menu for levels 2 and 3
| * 8f2b61b feat: task 50 - git bisect
| * 482f8e2 feat: task 49 - git reflog
| * 16e11e4 feat: task 48 - git tags
| * 1ac7033 feat: task 47 - git squash
| * ce634a5 feat: task 46 - git stash
| * df640d5 feat: task 45 - library
| * a72eb21 feat: task 44 - todo list
| * 402485d feat: task 43 - catch order
| * 1c71215 feat: task 42 - cancellation token
| * 1a96de6 feat: task 41 - when all
| * 8b21533 feat: task 40 - async await
| * 764eb3b feat: task 39 - yield even
| * 6c68a21 feat: task 38 - list vs linked list
| * 5f36817 feat: task 37 - fibonacci memo
| * c8ef43e feat: task 36 - duplicates
|/  
*   5f15a0a merge: level 2 into main
|\  
| * 50ba2f6 feat: task 35 - git scenario
| * 9066565 feat: task 34 - linq group words
| * abe2c86 feat: task 33 - linq employees
| * 8ebd4cb feat: task 32 - temperature
| * 597ce5d feat: task 31 - disposable
| * 1c3e89c feat: task 30 - bank account
| * 6ad4b8c feat: task 29 - notification factory
| * b9adcd8 feat: task 28 - point equals
| * 6cf4514 feat: task 27 - student sorting
| * 75fb17f feat: task 26 - discount strategy
| * 9374bb9 feat: task 25 - shapes
| * d4d8883 feat: task 24 - animals
| * fa9365b feat: task 23 - nullable
| * a11aa17 feat: task 22 - params sum
| * d262353 feat: task 21 - enum days
| * 3d63cc2 feat: task 20 - generics
| * 3847f13 feat: task 19 - my stack queue
| * a25e881 feat: task 18 - try parse vs try catch
| * d1b6984 feat: task 17 - string builder vs concat
| * 180924a feat: task 16 - string extensions
|/  
* 5ea6e52 Добавьте файлы проекта.
* 0648a30 Добавить .gitattributes, .gitignore и README.md.
```

### What I learned

Ветка позволяет вести работу отдельно от `main`, а конфликт при merge возникает, когда одну и ту же строку изменили в двух ветках, и его разрешают вручную.

## Task 35 — Branches & PR

### Commands

```bash
git add .gitignore .editorconfig
git commit -m "chore: add gitignore and editorconfig"
git push

git checkout -b feature/task-35
# создал task35-demo.txt и сделал три коммита
git commit -m "feat: task 35 - add demo file"
git commit -m "fix: task 35 - fix demo file"
git commit -m "docs: task 35 - update demo file"
git push -u origin feature/task-35
# Pull Request в main, squash-merge
git checkout main
git pull

git checkout -b feature/rebase-demo
git commit -m "wip: step 1"
git commit -m "wip: step 2"
git commit -m "wip: step 3"
git rebase -i HEAD~3   # второй и третий коммит заменил на squash
git commit --amend -m "feat: task 35 - rebase demo"
git push --force-with-lease origin feature/rebase-demo
```

### PR link

https://github.com/Hamater0/practice/pull/2

### Rebase result

До (`git log --oneline -4`):

```
e0572a3 wip: step 3
b1beb45 wip: step 2
006a3b6 wip: step 1
7d50c12 feat: task 35 - git workflow demo (#2)
```

После (`git log --oneline -4`):

```
68c1f78 feat: task 35 - rebase demo
7d50c12 feat: task 35 - git workflow demo (#2)
4b596eb chore: add gitignore and editorconfig
f3c6800 docs: update readme with task table
```

### What I learned

Pull Request позволяет проверить изменения перед слиянием в `main`, а `rebase -i` с `squash` объединяет несколько мелких коммитов в один и делает историю чище.

## Task 46 — git stash

### Commands

```bash
# изменил отслеживаемый файл task35-demo.txt, не коммитил
git stash
git stash list
git checkout -b feature/stash-demo
git checkout main
git stash pop
git stash list
```

### Output

`git stash list` до `git stash pop`:

```
stash@{0}: WIP on main: b0ee9f0 docs: task 35 - add git notes
```

`git stash list` после `git stash pop` (список пуст):

```
(пусто)
```

### What I learned

`git stash` временно прячет незакоммиченные изменения, `git stash pop` возвращает их и удаляет запись из списка.

## Task 47 — git rebase -i

### Commands

```bash
git checkout -b feature/squash-demo
git commit -m "wip: squash step 1"
git commit -m "wip: squash step 2"
git commit -m "wip: squash step 3"
git commit -m "wip: squash step 4"
git log --oneline
git rebase -i HEAD~4   # у второго, третьего и четвёртого коммита pick заменил на squash
git commit --amend -m "feat: task 47 - squash demo"
git log --oneline
git push -u origin feature/squash-demo
```

### Output

`git log --oneline` до:

```
1d9c3bd wip: squash step 4
089a011 wip: squash step 3
6a721b4 wip: squash step 2
ce04292 wip: squash step 1
690893d Merge branch 'main' of https://github.com/Hamater0/practice
```

`git log --oneline` после:

```
87df133 feat: task 47 - squash demo
690893d Merge branch 'main' of https://github.com/Hamater0/practice
4020589 docs: task 46 - add git notes
e0845a3  README.md
b0ee9f0 docs: task 35 - add git notes
```

### What I learned

В `rebase -i` у первого коммита остаётся `pick`, у остальных ставится `squash`, и четыре мелких коммита превращаются в один, история становится чище.

## Task 48 — tags

### Commands

```bash
git checkout main
git tag -a v1.0.0 -m "Release v1.0.0"
git push origin v1.0.0
git tag
git show v1.0.0
```

### Output

`git tag`:

```
v1.0.0
```

`git show v1.0.0` (без изменений файлов):

```
tag v1.0.0
Tagger: Hamater0 <gamovoff@yandex.ru>
Date:   Thu Nov 19 12:32:42 2026 +0300

Release v1.0.0

commit fac70976d29d9b60f265ae2f78a4fc2493a60288
Author: Hamater0 <gamovoff@yandex.ru>
Date:   Thu Nov 19 12:32:24 2026 +0300

    docs: task 47 - add git notes
```

Тег виден на GitHub: https://github.com/Hamater0/practice/tags

### What I learned

Аннотированный тег хранит автора, дату и сообщение, поэтому им удобно отмечать релизы. Его нужно отправлять отдельно командой `git push origin v1.0.0`.

## Task 49 — reflog

### Commands

```bash
git checkout -b feature/reflog-demo
git add reflog-demo.txt
git commit -m "feat: add reflog demo"
git reset --hard HEAD~1
git reflog
git reset --hard <hash>
git reflog
git log --oneline
```

### Output

`git reflog` после `git reset --hard HEAD~1` (коммит пропал из `git log`, но виден в reflog):

```
ebaf613 HEAD@{0}: reset: moving to HEAD~1
0759636 HEAD@{1}: commit: feat: add reflog demo
ebaf613 HEAD@{2}: checkout: moving from main to feature/reflog-demo
ebaf613 HEAD@{3}: checkout: moving from main to main
ebaf613 HEAD@{4}: commit: docs: task 48 - add git notes
fac7097 HEAD@{5}: commit: docs: task 47 - add git notes
```

`git reflog` после восстановления:

```
0759636 HEAD@{0}: reset: moving to 0759636
ebaf613 HEAD@{1}: reset: moving to HEAD~1
0759636 HEAD@{2}: commit: feat: add reflog demo
ebaf613 HEAD@{3}: checkout: moving from main to feature/reflog-demo
ebaf613 HEAD@{4}: checkout: moving from main to main
ebaf613 HEAD@{5}: commit: docs: task 48 - add git notes
```

`git log --oneline` после восстановления:

```
0759636 feat: add reflog demo
ebaf613 docs: task 48 - add git notes
fac7097 docs: task 47 - add git notes
```

### What I learned

`git reflog` хранит историю перемещений `HEAD`, поэтому даже после `reset --hard` потерянный коммит можно найти по хешу и вернуть.

## Task 50 — bisect

### Commands

```bash
git checkout -b feature/bisect-demo
# сделал 10 коммитов "feat: step 1…10", в 6-м добавил строку BROKEN в bisect-demo.txt
git bisect start
git bisect bad
git bisect good <hash коммита step 1>
# на каждом шаге смотрел файл: есть BROKEN — git bisect bad, нет — git bisect good
git bisect good
git bisect bad
git bisect bad
git bisect log
git bisect reset
```

### Output

`git bisect log` (в конце видно найденный «плохой» коммит):

```
git bisect start
# status: waiting for both 'good' and 'bad' commits
# bad: [da5ca2c6a90611634c60178eb37af0289946e867] feat: step 10
git bisect bad da5ca2c6a90611634c60178eb37af0289946e867
# status: waiting for 'good' commit(s), 'bad' commit known
# good: [65157ac4694dc079744bceaf91f38bbab1b42a95] feat: step 1
git bisect good 65157ac4694dc079744bceaf91f38bbab1b42a95
# good: [c8ddae438db7336118e383dc040ef10674df8128] feat: step 5
git bisect good c8ddae438db7336118e383dc040ef10674df8128
# bad: [29f786e50d1d64f2c18aed6aaaff29d4b8263231] feat: step 7
git bisect bad 29f786e50d1d64f2c18aed6aaaff29d4b8263231
# bad: [efd2d8717e51f4ef5757614bf120b23fdbd642bd] feat: step 6
git bisect bad efd2d8717e51f4ef5757614bf120b23fdbd642bd
# first 'bad' commit: [efd2d8717e51f4ef5757614bf120b23fdbd642bd] feat: step 6
```

Результат: Git нашёл первый «плохой» коммит `efd2d87` (`feat: step 6`), то есть именно тот, в котором я добавил строку `BROKEN`.

### What I learned

`git bisect` ищет «плохой» коммит бинарным поиском: на каждом шаге делит историю пополам, поэтому для 10 коммитов хватило трёх проверок.
